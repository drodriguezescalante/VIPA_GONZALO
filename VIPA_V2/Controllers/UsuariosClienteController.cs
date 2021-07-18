using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIPA_V2.Models;
using VIPA_V2.Transfer;
namespace VIPA_V2.Controllers
{
    public class UsuariosClienteController : ApiController
    {
        [HttpGet]
        [Route("api/Usuarioscliente/ListarUsuarioscliente")]
        public IEnumerable<UsuariosClienteDT> ListarUsuarioscliente() //DR 10/07/2021: Ok
        {
            return usuarioscliente.ListarUsuarioscliente();
        }
    }
}
