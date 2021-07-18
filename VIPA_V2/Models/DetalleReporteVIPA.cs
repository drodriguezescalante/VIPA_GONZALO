using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;

namespace VIPA_V2.Models
{
    public partial class detallereporteusuariocliente
    {
        public static ReporteDT2 ObtenerDetalleReporte(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.reportes.Select(b => new ReporteDT2()
            {
                idreporte = b.idreporte,
                idurlvideo = b.idurlvideo,
                fechacreacion = b.fechacreacion,
                nombredistrito = b.nombredistrito,
                tiporeporte = new TipoReporteDT()
                {
                    reportenombre = b.tiporeporte.reportenombre
                }
            }).SingleOrDefault(b => b.idreporte == id);
            if (obj == null) obj = new ReporteDT2() { idreporte = "No se encontró" };
            return obj;
        }

        public static IEnumerable<DetalleReporteDT2> ListarDetalledereporte()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.detallereporteusuarioclientes.ToList()
                       select new DetalleReporteDT2()
                       {
                           idreporte = b.idreporte,
                           idreportador = b.idreportador,
                           idtiporeporte = b.idtiporeporte,
                           idcliente = b.idcliente

                       };
            return list;
        }

        public static IEnumerable<ReporteDT2> Listardetallereporte()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportes.ToList()
                       select new ReporteDT2()
                       {
                           idreporte = b.idreporte,
                           idurlvideo = b.idurlvideo,
                           nombredistrito = b.nombredistrito,
                           tiporeporte = new TipoReporteDT()
                           {
                               reportenombre = b.tiporeporte.reportenombre
                           },
                           fechacreacion = b.fechacreacion
                       };
            return list;
        }

        public static IEnumerable<DetalleReporteDT> ListarDetallesTotal()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportes.ToList()

                       select new DetalleReporteDT()
                       {
                           idreporte = b.idreporte,
                           idurlvideo = b.idurlvideo,
                           idurlgps = b.idurlgps,
                           nombredistrito = b.nombredistrito,
                           idplacavehiculo = b.idplacavehiculo,
                           descripcionreporte = b.descripcionreporte,
                           fechacreacion = (DateTime)b.fechacreacion
                       };
            return list;
        }
        public static DetalleReporteDT listaDetalleid(string idreporte)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.reportes.Select(b => new DetalleReporteDT()
            {
                idreporte = b.idreporte,
                idurlvideo = b.idurlvideo,
                idurlgps = b.idurlgps,
                nombredistrito = b.nombredistrito,
                idplacavehiculo = b.idplacavehiculo,
                descripcionreporte = b.descripcionreporte,
                tiporeporte = new TipoReporteResponse()
                {
                    reportenombre = b.tiporeporte.reportenombre
                },
                fechacreacion = (DateTime)b.fechacreacion
            }).SingleOrDefault(b => b.idreporte == idreporte);
            if (obj == null) obj = new DetalleReporteDT { idreporte = "no se encuentra" };
            return obj;
        }
    }
}