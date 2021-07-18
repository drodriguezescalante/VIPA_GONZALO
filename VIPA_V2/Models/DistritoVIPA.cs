using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
using VIPA_V2.Models;

namespace VIPA_V2.Models
{
    public partial class distrito
    {
        public static IEnumerable<DistritoDT> ListarDistritos()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.distritoes.ToList()
                       select new DistritoDT()
                       {
                           iddistrito = b.iddistrito,
                           nombredistrito = b.nombredistrito
                       };
            return list;
        }
    }
}