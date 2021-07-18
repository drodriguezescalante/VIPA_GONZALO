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
    public class TipoReporteController : ApiController
    {
        [HttpGet]
        [Route("api/TipoReporte/ListarTipoReporte")]
        public IEnumerable<TipoReporteDT> ListarTipoReporte()
        {
            return tiporeporte.ListarTipoReporte();
        }
    }
}
