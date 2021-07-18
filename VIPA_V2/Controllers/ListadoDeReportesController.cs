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
    public class ListadoDeReportesController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        [Route("api/Reporte/listarbusquedad")] //DR 08-07-2021: No filtra mas de 1 registro por distrito. Probar con el distrito de San Miguel.
        public BusquedaDistritoDT listarbusquedad(string nombredistrito)
        {
            return BusquedaReporte.listarbusquedad(nombredistrito);
        }

        [HttpGet]
        [Route("api/Reporte/listarbusquedap")] //DR 08-07-2021: No filtra mas de 1 registro por placa. Probar con la placa ABC-123.
        public BusquedaDistritoDT listarbusquedap(string idplacavehiculo)
        {
            return BusquedaReporte.listarbusquedap(idplacavehiculo);
        }


        //[HttpGet]

        //[Route("api/Reporte/ListarDetallesTotal")]
        //public IEnumerable<DetalleReportedt> ListarDetallesTotal()
        //{
        //    return DetalleReporte.ListarDetallesTotal();
        //}

        [HttpGet]

        [Route("api/Reporte/listaDetalleid")] //DR 08-07-2021: OK.
        public DetalleReporteDT listaDetalleid(string idreporte)
        {
            return detallereporteusuariocliente.listaDetalleid(idreporte);
        }


        [HttpGet]
        [Route("api/Reporte/ListadoDeReportes")] //DR 08-07-2021: OK.
        public IEnumerable<ListadoReportesDT> ListadoDeReportes()
        {
            return BusquedaReporte.ListadoDeReportes();
        }
    }
}
