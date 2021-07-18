using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class PublicacionesRecientesDT
    {
        public string idurlvideo { get; set; }

        public string nombredistrito { get; set; }

        public Nullable<System.DateTime> fechacreacion { get; set; }

        public TipoReporteDT tiporeporte { get; set; }
    }
}