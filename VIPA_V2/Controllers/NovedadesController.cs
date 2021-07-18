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
    public class NovedadesController : ApiController
    {
        [HttpGet]
        [Route("api/Consejo/ListarConsejo")] //DR 10/07/2021: Ok
        public IEnumerable<ConsejoDT> ListarConsejo()
        {
            return consejo.ListarConsejo();
        }

        [HttpGet]
        [Route("api/Reporte/ListarPublicacioneRecientes")] //DR 10/07/2021: Ok
        public IEnumerable<PublicacionesRecientesDT> ListarPublicacioneRecientes()
        {
            return reporte.ListarPublicacioneRecientes();
        }


        [HttpGet]
        [Route("api/Reporte/Listardetallereporte")] //DR 10/07/2021: Ok
        public IEnumerable<ReporteDT2> Listarreporte()
        {
            return detallereporteusuariocliente.Listardetallereporte();
        }


        [HttpGet]
        [Route("api/Reporte/ObtenerDetalleReporte")] //DR 10/07/2021: Ok
        public ReporteDT2 ObtenerDetalleReporte(string id)
        {
            return detallereporteusuariocliente.ObtenerDetalleReporte(id);
        }
    }
}
