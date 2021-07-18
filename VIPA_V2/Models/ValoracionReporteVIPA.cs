using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VIPA_V2.Transfer;

namespace VIPA_V2.Models
{
    public partial class valoracionreporte
    {
        public static ReporteUrlDT ObtenerUrlAleatorio()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportes
                       orderby Guid.NewGuid()
                       select new ReporteUrlDT
                       {
                           idurlvideo = b.idurlvideo,
                           idreportador = b.idreportador,
                           idreporte = b.idreporte,
                           idtiporeporte = b.idtiporeporte

                       };

            var response = list.FirstOrDefault();
            return response;
        }
        public static ValoracionReporteUrlDT ObtenerValoracionReporte(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var reporteURL = valoracionreporte.ObtenerUrlAleatorio();
            var obj = db.valoracionreportes.Select(b => new ValoracionReporteUrlDT()
            {

                idvaloracion = b.idvaloracion,
                segundotipovaloracion = b.segundotipovaloracion,
                reportevideo = reporteURL.idurlvideo,
                idreportador = reporteURL.idreportador,
                idreporte = reporteURL.idreporte,
                idtiporeporte = reporteURL.idtiporeporte,
                puntosganados = new EstadoPerfilRankingPuntosDT
                {
                    puntos = 50
                }
            }).SingleOrDefault(b => b.idvaloracion == id);

            if (obj == null) obj = new ValoracionReporteUrlDT() { idvaloracion = "No se encontro la valoracion del reporte." };

            return obj;
        }


        public static ValoracionReporteUrlDT RegistrarValoracionReporte(ValoracionReporteUrlDT valoracionreporteURLdt)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();

            valoracionreporte valoracionreporte = new valoracionreporte()
            {
                idvaloracion = valoracionreporteURLdt.idvaloracion,
                segundotipovaloracion = valoracionreporteURLdt.segundotipovaloracion
            };

            var reporteURL = valoracionreporte.ObtenerUrlAleatorio(); //Obtener reporte aleatorio.

            valoracionreporte valoracionreporte2 = new valoracionreporte()
            {
                idvaloracion = valoracionreporteURLdt.idvaloracion,
                segundotipovaloracion = valoracionreporteURLdt.segundotipovaloracion,

                idreporte = reporteURL.idreporte,
                idreportador = reporteURL.idreportador,
                idtiporeporte = reporteURL.idtiporeporte
            };

            EstadoPerfilRankingDT send = new EstadoPerfilRankingDT();
            send.puntosactuales = PuntosValoracion(valoracionreporte2.segundotipovaloracion); //Obtener puntos segun la valoracion.

            ReportadorRankingDT perfil = ObtenerReportadorRanking(valoracionreporte2.idreportador); //Obtener el id del perfilRanking segun el id del reportante.

            var puntosGanados = valoracionreporte.ActualizarPuntos(perfil.idestadoperfil, send); //Actualizar segun el id del reportador.

            db.valoracionreportes.Add(valoracionreporte2);
            db.SaveChanges();
            return ObtenerValoracionReporte(valoracionreporte2.idvaloracion);
        }
        public static EstadoPerfilRankingDT ActualizarPuntos(string id, EstadoPerfilRankingDT estadoperfilrankingdt)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            estadoperfilranking obj = db.estadoperfilrankings.SingleOrDefault(m => m.idestadoperfil == id);
            obj.puntosactuales += estadoperfilrankingdt.puntosactuales;
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return ObtenerPerfilRanking(id);
        }

        public static IEnumerable<ValoracionReporteDT> ListarValoracionReporte()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.valoracionreportes.ToList()
                       select new ValoracionReporteDT()
                       {
                           idvaloracion = b.idvaloracion,
                           segundotipovaloracion = b.segundotipovaloracion,
                           idreporte = b.idreporte,
                           idreportador = b.idreportador,
                           idtiporeporte = b.idtiporeporte
                       };
            return list;
        }
        public static ValoracionReporteUrlDT ActualizarValoracionReporte(string id, ValoracionReporteUrlDT valoracionreporteURLdt)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            valoracionreporte obj = db.valoracionreportes.SingleOrDefault(m => m.idvaloracion == id);
            obj.segundotipovaloracion = valoracionreporteURLdt.segundotipovaloracion;
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return ObtenerValoracionReporte(id);
        }
        public static EstadoPerfilRankingDT ObtenerPerfilRanking(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.estadoperfilrankings.Select(b => new EstadoPerfilRankingDT()
            {
                idestadoperfil = b.idestadoperfil,
                nivelraking = b.nivelraking,
                puntosactuales = b.puntosactuales
            }).SingleOrDefault(b => b.idestadoperfil == id);

            if (obj == null) obj = new EstadoPerfilRankingDT() { idestadoperfil = "" };

            return obj;
        }
        public static ReportadorRankingDT ObtenerReportadorRanking(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.reportadors.Select(b => new ReportadorRankingDT()
            {
                idreportador = b.idreportador,
                idestadoperfil = b.idestadoperfil
            }).SingleOrDefault(b => b.idreportador == id);

            if (obj == null) obj = new ReportadorRankingDT() { idreportador = "No se encontro el reportador." };

            return obj;
        }
        public static int PuntosValoracion(string valoracion)
        {
            int resultado = 0;
            if (valoracion.Equals("leve")) resultado = 50;
            else if (valoracion.Equals("medio")) resultado = 80;
            else if (valoracion.Equals("moderado")) resultado = 100;
            else if (valoracion.Equals("grave")) resultado = 150;
            else if (valoracion.Equals("extremo")) resultado = 200;
            return resultado;
        }
        public static int ActualizarNivel(int? puntos)
        {
            puntos = 0;
            int nivel = 0;
            if (puntos <= 500) nivel = 1;
            else if (puntos > 500 && puntos <= 1000) nivel = 2;
            else if (puntos > 1000 && puntos <= 1500) nivel = 3;
            else if (puntos > 1500 && puntos <= 2000) nivel = 4;
            else if (puntos > 2000) nivel = 5;
            return nivel;
        }
    }
}