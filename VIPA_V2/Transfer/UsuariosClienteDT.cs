using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class UsuariosClienteDT
    {
        public string idusuariocliente { get; set; }
        public string idcliente { get; set; }
        public string nombreusuariocliente { get; set; }
        public string correousuariocliente { get; set; }
        public string contraseñausuariocliente { get; set; }
    }
    public class loginform
    {
        public string correousuariocliente { get; set; }
        public string contraseñausuariocliente { get; set; }
    }
}