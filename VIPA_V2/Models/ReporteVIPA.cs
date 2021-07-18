using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Models;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class reporte
    {
        public static IEnumerable<ReporteDT> ListarReporte()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportes.ToList()
                       select new ReporteDT()
                       {
                           idreporte = b.idreporte,
                           idreportador = b.idreportador,
                           idtiporeporte = b.idtiporeporte,
                           idurlvideo = b.idurlvideo,
                           idurlgps = b.idurlgps,
                           nombredistrito = b.nombredistrito,
                           idplacavehiculo = b.idplacavehiculo,
                           descripcionreporte = b.descripcionreporte,
                           estadoreporte = b.estadoreporte,
                           fechacreacion = b.fechacreacion
                       };
            return list;
        }
        public static ReporteDT ObtenerReporte(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.reportes.Select(b =>
            new ReporteDT()
            {
                idreporte = b.idreporte,
                idreportador = b.idreportador,
                idtiporeporte = b.idtiporeporte,
                idurlvideo = b.idurlvideo,
                idurlgps = b.idurlgps,
                nombredistrito = b.nombredistrito,
                idplacavehiculo = b.idplacavehiculo,
                descripcionreporte = b.descripcionreporte,
                fechacreacion = b.fechacreacion
            }).SingleOrDefault(b => b.idreporte == id);
            return obj;
        }
        public static ReporteDT RegistrarReporte(string id, ReporteDT reportedt)
        {
            DateTime now = DateTime.Now;
            vipa_databaseEntities db = new vipa_databaseEntities();
            int contador = db.reportes.Where(t => t.idreporte == reportedt.idreporte).Count();
            if (contador > 0)
            {
                return null;
            }
            reporte obj = new reporte()
            {
                idreporte = reportedt.idreporte,
                idreportador = reportedt.idreportador,
                idtiporeporte = reportedt.idtiporeporte,
                idurlvideo = reportedt.idurlvideo,
                idurlgps = reportedt.idurlgps,
                nombredistrito = reportedt.nombredistrito,
                idplacavehiculo = reportedt.idplacavehiculo,
                descripcionreporte = reportedt.descripcionreporte,
                fechacreacion = now
            };
            db.reportes.Add(obj);
            db.SaveChanges();
            return ObtenerReporte(id);
        }

    }
}