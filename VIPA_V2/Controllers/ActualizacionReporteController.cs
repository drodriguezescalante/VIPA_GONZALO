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
    public class ActualizacionReporteController : ApiController
    {
        [HttpGet]
        [Route("api/ActualizacionReporte/obteneractualizaciones")] //DR10/07/2021: OK
        public ActualizacionEstadoDT obteneractualizaciones(string id)
        {
            return reporte.obteneractualizaciones(id);
        }

        [HttpGet]
        [Route("api/ActualizacionReporte/ListarReportesValidacion")] //DR10/07/2021: OK
        public IEnumerable<ValidacionReporteDT> ListarReportesValidacion()
        {
            return reporte.ListarReportesValidacion();
        }

        [HttpGet]
        [Route("api/ActualizacionReporte/Logincliente")] //DR10/07/2021: Ok
        public Boolean validarcliente(string correocliente, string contraseñacliente)
        {
            return usuarioscliente.validarcliente(correocliente, contraseñacliente);
        }
    }
}
