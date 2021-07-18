using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;

namespace VIPA_V2.Models
{
    public partial class cliente
    {
        public static IEnumerable<ClienteDT> ListarCliente()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.clientes.ToList()
                       select new ClienteDT()
                       {
                           idcliente = b.idcliente,
                           nombrecliente = b.nombrecliente,
                           nombredistrito = b.nombredistrito,
                           fechacreacion = b.fechacreacion.Value.ToString("dd/MM/yy"),
                       };
            return list;
        }

        public static bool LoginCliente(string correousuariocliente, string contraseñausuariocliente)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();

            var e = (from p in db.usuariosclientes
                     where p.correousuariocliente == correousuariocliente && p.contraseñausuariocliente == contraseñausuariocliente
                     select p).Any();
            if (e)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}