using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;

namespace VIPA_V2.Models
{
    public partial class consejo
    {
        public static IEnumerable<ConsejoDT> ListarConsejo()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.consejoes.ToList()
                       select new ConsejoDT()
                       {
                           idconsejo = b.idconsejo,
                           nombreconsejo = b.nombreconsejo,
                           urlconsejovideo = b.urlconsejovideo
                       };
            return list;
        }
    }
}