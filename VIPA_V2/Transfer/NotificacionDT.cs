using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class NotificacionDT
    {
        public int idnotificacion { get; set; }
        public string nombrenotificacion { get; set; }
        public string descripcionnotificacion { get; set; }
        public string urlincidente { get; set; }
        public Nullable<System.DateTime> fechadespliegue { get; set; }
    }
}