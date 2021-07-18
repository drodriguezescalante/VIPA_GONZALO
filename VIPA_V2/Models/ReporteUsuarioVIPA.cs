using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class reporte
    {
        public static IEnumerable<ReporteUsuarioDT> ListarVideosUsuario(string idUsuario)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportes.Where(t => t.idreportador == idUsuario)
                       select new ReporteUsuarioDT()
                       {
                           idreporte = b.idreporte,
                           idreportador = b.idreportador,
                           idurlvideo = b.idurlvideo,
                           idurlgps = b.idurlgps,
                           nombredistrito = b.nombredistrito,
                           idplacavehiculo = b.idplacavehiculo,
                           descripcionreporte = b.descripcionreporte,

                       };
            return list;
        }
    }
}