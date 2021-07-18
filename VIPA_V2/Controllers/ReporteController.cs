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
    public class ReporteController : ApiController
    {
        [HttpGet]
        [Route("api/Reporte/RegistrarReporte")] //DR 10/07/2021: OK
        public ReporteDT RegistrarReporte(string idreporte, string idreportador, int idtiporeporte, string idurlvideo, string idurlgps, string nombredistrito, string idplacavehiculo, string descripcionreporte)
        {
            ReporteDT obj = new ReporteDT()
            {
                idreporte = idreporte,
                idreportador = idreportador,
                idtiporeporte = idtiporeporte,
                idurlvideo = idurlvideo,
                idurlgps = idurlgps,
                nombredistrito = nombredistrito,
                idplacavehiculo = idplacavehiculo,
                descripcionreporte = descripcionreporte

            };
            return reporte.RegistrarReporte(idreporte, obj);
        }
        [HttpGet]
        [Route("api/Reporte/ListarDistritos")] //DR 10/07/2021: OK
        public IEnumerable<DistritoDT> ListarDistritos()
        {
            return distrito.ListarDistritos();
        }
    }
}
