using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class terminocondicion
    {
        public static IEnumerable<TerminoCondicionDT> ListarTerminosCondiciones()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.terminocondicions.ToList()
                       select new TerminoCondicionDT()
                       {
                           reglaid = b.reglaid,
                           titulo = b.titulo,
                           descripcionregla = b.descripcionregla
                       };
            return list;
        }
    }
}