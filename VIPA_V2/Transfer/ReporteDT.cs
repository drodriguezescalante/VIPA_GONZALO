using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class ReporteDT
    {
        public string idreporte { get; set; }
        public string idreportador { get; set; }
        public int idtiporeporte { get; set; }
        public string idurlvideo { get; set; }
        public string idurlgps { get; set; }
        public string nombredistrito { get; set; }
        public string idplacavehiculo { get; set; }
        public string descripcionreporte { get; set; }
        public string estadoreporte { get; set; }
        public Nullable<System.DateTime> fechacreacion { get; set; }
    }
    public class Reporte2DT
    {
        public string idurlgps { get; set; }
    }
    public class ReporteUrlDT
    {
        public string idurlvideo { get; set; }
        public string idreportador { get; set; }
        public string idreporte { get; set; }
        public int idtiporeporte { get; set; }
    }
}