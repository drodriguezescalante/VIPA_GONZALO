using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class ReportadorDT2
    {
        public string idreportador { get; set; }
        public string aliasusuario { get; set; }
        public string perfilvisible { get; set; }
        public string nombrereportador { get; set; }
        public string apellidosreportador { get; set; }
        public string correoreportador { get; set; }
        public string contraseniareportador { get; set; }
        public string idestadoperfil { get; set; }
        public String verificacionperfil { get; set; }
    }
    public class loginreportadorform
    {
        public string correoreportador { get; set; }
        public string contraseñareportador { get; set; }
    }
}