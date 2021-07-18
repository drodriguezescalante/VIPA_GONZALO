using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class ValidacionReporteDT
    {
        public string idreportador { get; set; }
        public string nombredistrito { get; set; }
        public string idurlgps { get; set; }
        public int idtiporeporte { get; set; }
        public string idplacavehiculo { get; set; }
        public Nullable<System.DateTime> fechacreacion { get; set; }
        public string descripcionreporte { get; set; }
    }
}