using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Models
{
    public partial class usuarioscliente
    {
        public static Boolean validarcliente(string correocliente, string contraseñacliente)
        {
            Boolean rpta;
            try
            {
                vipa_databaseEntities db = new vipa_databaseEntities();
                var obj = (from p in db.usuariosclientes
                           where p.correousuariocliente == correocliente && p.contraseñausuariocliente == contraseñacliente
                           select p);

                var rpse = obj.FirstOrDefault();

                if (rpse != null)
                    rpta = true;
                else
                    rpta = false;
            }
            catch (Exception e)
            {
                rpta = false;
            }
            return rpta;
        }
    }
}