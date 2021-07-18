using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class usuarioscliente
    {
        public static IEnumerable<UsuariosClienteDT> ListarUsuarioscliente()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.usuariosclientes.ToList()
                       select new UsuariosClienteDT()
                       {
                           idusuariocliente = b.idusuariocliente,
                           idcliente = b.idcliente,
                           nombreusuariocliente = b.nombreusuariocliente,
                           correousuariocliente = b.correousuariocliente,
                           contraseñausuariocliente = b.contraseñausuariocliente
                       };
            return list;
        }
    }
}