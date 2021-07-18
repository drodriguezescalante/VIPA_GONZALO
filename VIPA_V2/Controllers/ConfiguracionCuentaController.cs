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
    public class ConfiguracionCuentaController : ApiController
    {

        [HttpGet]
        [Route("api/PreguntasFrecuentes/ListarPreguntasFrecuentes")] //DR 08-07-2021: OK.
        public IEnumerable<PreguntaFrecuenteDT> ListarPreguntasFrecuentes()
        {
            return preguntafrecuente.ListarPreguntasFrecuentes();
        }
        [HttpGet]
        [Route("api/Reportador/ObtenerPerfil")] //DR 08-07-2021: OK.
        public ReportadorDT ObtenerReportador(string id)
        {
            return reportador.ObtenerReportador(id);
        }

        [HttpGet]
        [Route("api/Reportador/ActualizarPerfil")] //DR 08-07-2021: OK.
        public ReportadorDT ActualizarPerfil(string id, string aliasusuario, string perfilvisible, string nombrereportador, string apellidosreportador, string correoreportador)
        {
            ReportadorDT obj = new ReportadorDT()
            {
                aliasusuario = aliasusuario,
                perfilvisible = perfilvisible,
                nombrereportador = nombrereportador,
                apellidosreportador = apellidosreportador,
                correoreportador = correoreportador
            };
            return reportador.ActualizarPerfil(id, obj);
        }
        [HttpGet]
        [Route("api/ReportesUsuario/ListarVideosUsuario")] //DR 08-07-2021: OK.
        public IEnumerable<ReporteUsuarioDT> ListarVideosUsuario(string id)
        {
            return reporte.ListarVideosUsuario(id);
        }
        [HttpGet]
        [Route("api/TerminoCondicion/ListarTerminosCondiciones")] //DR 08-07-2021: OK.
        public IEnumerable<TerminoCondicionDT> ListarTerminosCondiciones()
        {
            return terminocondicion.ListarTerminosCondiciones();
        }
    }
}
