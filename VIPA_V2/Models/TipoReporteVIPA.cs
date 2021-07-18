using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class tiporeporte
    {
        public static IEnumerable<TipoReporteDT> ListarTipoReporte()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.tiporeportes.ToList()
                       select new TipoReporteDT()
                       {
                           idtiporeporte = b.idtiporeporte,
                           reportenombre = b.reportenombre,
                           reporteindicador = b.reporteindicador,
                           idreportepadre = (int)b.idreportepadre
                       };
            return list;
        }

        public static IEnumerable<TipoReporteDT> ListarCatReporte()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.tiporeportes.ToList()
                       select new TipoReporteDT()
                       {
                           reportenombre = b.reportenombre,

                       };
            return list;
        }
    }
}