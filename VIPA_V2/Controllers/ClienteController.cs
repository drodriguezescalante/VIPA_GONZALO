using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIPA_V2.Transfer;
using VIPA_V2.Models;

namespace VIPA_V2.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("api/Cliente/ListarCliente")] //DR 10/07/2021: Ok
        public IEnumerable<ClienteDT> ListarCliente()
        {
            return cliente.ListarCliente();
        }

        //[HttpPost]
        //[Route("api/Cliente/LoginCliente")]
        //public bool LoginCliente()
        //{
        //    string cor = "gonzafebres@yahoo.es";
        //    string con = "123456";
        //    return cliente.LoginCliente(cor,con);
        //}

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("api/Cliente/Login")]
        //public bool Login([FromBody] loginform request)
        //{
        //        //Function to save data in the DB
        //        var cor = request.correousuariocliente;
        //        var con = request.contraseñausuariocliente;
        //    return cliente.LoginCliente(cor, con);
        //}
    }
}
