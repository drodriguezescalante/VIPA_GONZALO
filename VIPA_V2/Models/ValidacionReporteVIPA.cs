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
        public static IEnumerable<ValidacionReporteDT> ListarReportesValidacion()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportes.ToList()
                       select new ValidacionReporteDT()
                       {
                           idreportador = b.idreportador,
                           idurlgps = b.idurlgps,
                           idtiporeporte = b.idtiporeporte,
                           idplacavehiculo = b.idplacavehiculo,
                           fechacreacion = b.fechacreacion,
                           descripcionreporte = b.descripcionreporte,
                           nombredistrito = b.nombredistrito
                       };
            return list;
        }
    }
}