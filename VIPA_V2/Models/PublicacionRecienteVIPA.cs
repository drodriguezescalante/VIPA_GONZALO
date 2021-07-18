using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class reporte
    {
        public static IEnumerable<PublicacionesRecientesDT> ListarPublicacioneRecientes()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            DateTime fecha = DateTime.Today;
            fecha = fecha.AddDays(-5);
            var list = from b in db.reportes.Where(f => f.fechacreacion > fecha)

                       select new PublicacionesRecientesDT()
                       {
                           idurlvideo = b.idurlvideo,
                           tiporeporte = new TipoReporteDT()
                           {
                               reportenombre = b.tiporeporte.reportenombre
                           },
                           nombredistrito = b.nombredistrito,
                           fechacreacion = b.fechacreacion
                       };
            return list;
        }
    }
}