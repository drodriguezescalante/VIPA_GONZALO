using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class TipoReporteDT
    {
        public int idtiporeporte { get; set; }
        public string reportenombre { get; set; }
        public string reporteindicador { get; set; }
        public int idreportepadre { get; set; }
    }
    public class TipoReporteResponse
    {
        public string reportenombre { get; set; }
    }
}