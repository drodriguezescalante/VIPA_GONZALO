using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class DetalleReporteDT
    {
        public string idreporte { get; set; }
        public string idurlvideo { get; set; }
        public string idurlgps { get; set; }
        public string nombredistrito { get; set; }
        public string idplacavehiculo { get; set; }
        public string descripcionreporte { get; set; }
        public TipoReporteResponse tiporeporte { get; set; }
        public DateTime fechacreacion { get; set; }
    }
}