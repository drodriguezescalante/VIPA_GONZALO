using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class ReporteUsuarioDT
    {
        public string idreporte { get; set; }
        public string idreportador { get; set; }
        public int idtiporeporte { get; set; }
        public string idurlvideo { get; set; }
        public string idurlgps { get; set; }
        public string nombredistrito { get; set; }
        public string idplacavehiculo { get; set; }
        public string descripcionreporte { get; set; }
    }
}