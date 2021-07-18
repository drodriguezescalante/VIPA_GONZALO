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
    public class RankingController : ApiController
    {
        [HttpGet]
        [Route("api/Ranking/ListarCatReporte")] //DR 08-07-2021: Ok
        public IEnumerable<TipoReporteDT> ListarCatReporte()
        {
            return tiporeporte.ListarCatReporte();
        }

        //tipo de reporte
        [HttpGet]
        [Route("api/Ranking/ListarTipoReporte")] ////DR 08-07-2021: Ok
        public IEnumerable<TipoReporteDT> ListarTipoReporte()
        {
            return tiporeporte.ListarTipoReporte();
        }

        [HttpGet]
        [Route("api/Ranking/ListarValoracionReporte")] //DR 08-07-2021: Ok
        public IEnumerable<ValoracionReporteDT> ListarValoracionReporte()
        {
            return valoracionreporte.ListarValoracionReporte();
        }

        [HttpGet]
        [Route("api/Ranking/ListarPerfilRanking")] //DR 08-07-2021: Ok
        public IEnumerable<EstadoPerfilRankingDT> ListarPerfilRanking()
        {
            return estadoperfilranking.ListarPerfilRanking();
        }

        [HttpGet]
        [Route("api/Ranking/ListarRankingGlobal")] //DR 08-07-2021: Ok
        public IEnumerable<RankingGlobalDT> ListarRankingGlobal()
        {
            return rankingglobal.ListarRankingGlobal();
        }
        //REPORTADOR
        [HttpGet]
        [Route("api/Ranking/ListarReportador")] //DR 10-07-2021: Ok
        public IEnumerable<ReportadorDT2> ListarReportador()
        {
            return reportador.ListarReportador();
        }

        //REPORTE
        [HttpGet]
        [Route("api/Ranking/ListarReporte")] //DR 10-07-2021: Ok
        public IEnumerable<ReporteDT> ListarReporte()
        {
            return reporte.ListarReporte();
        }

        [HttpGet]
        [Route("api/Ranking/ObtenerValoracionReporte")] //DR 10-07-2021: Ok
        public ValoracionReporteUrlDT ObtenerValoracionReporte(string id)
        {
            return valoracionreporte.ObtenerValoracionReporte(id);
        }

        [HttpGet]
        [Route("api/Ranking/RegistrarValoracionReporte")] //DR 10-07-2021: Tuve problemas para actualizar tabla estadoperfilranking.FALTA RELACIONAR AL REPORTADOR
        public ValoracionReporteUrlDT RegistrarValoracionReporte(string idvaloracion, string segundotipovaloracion, string idreporte, string idreportador, int idtiporeporte)
        {
            ValoracionReporteUrlDT obj = new ValoracionReporteUrlDT()
            {
                idvaloracion = idvaloracion,
                segundotipovaloracion = segundotipovaloracion,
                idreporte = idreporte,
                idreportador = idreportador,
                idtiporeporte = idtiporeporte
            };
            return valoracionreporte.RegistrarValoracionReporte(obj);
        }
        [HttpGet]
        [Route("api/Ranking/ObtenerUrlAleatorio")] //DR 10/07/2021:OK
        public ReporteUrlDT ObtenerUrlAleatorio()
        {
            return valoracionreporte.ObtenerUrlAleatorio();
        }

        [HttpGet]
        [Route("api/Ranking/ActualizarValoracionReporte")]  //DR 10/07/2021:OK
        public ValoracionReporteUrlDT ActualizarValoracionReporte(string id, string segundotipovaloracion)
        {
            ValoracionReporteUrlDT obj = new ValoracionReporteUrlDT()
            {
                segundotipovaloracion = segundotipovaloracion
            };
            return valoracionreporte.ActualizarValoracionReporte(id, obj);
        }

        //PERFIL RANKING
        [HttpGet]
        [Route("api/Ranking/ListarRankingPuntos")] //DR 10/07/2021:OK
        public IEnumerable<EstadoPerfilRankingDT> ListarRankingPuntos()
        {
            return estadoperfilranking.ListarRankingPuntos();
        }

        [HttpGet]
        [Route("api/Ranking/ListarNivelDesbloqueado")] //DR 10/07/2021:OK
        public IEnumerable<EstadoPerfilRankingDT2> ListarNivelDesbloqueado()
        {
            return estadoperfilranking.ListarNivelDesbloqueado();
        }

        [HttpGet]
        [Route("api/Ranking/ObtenerPerfilRanking")] //DR 10/07/2021:FUNCIONA, PERO FALTA EL CÓDIGO DEL REPORTADOR
        public EstadoPerfilRankingDT4 ObtenerPerfilRanking(string id)
        {
            return estadoperfilranking.ObtenerPerfilRanking(id);
        }

        [HttpGet]
        [Route("api/Ranking/ObtenerReportadorRanking")] // DR 10/07/2021: Funciona, pero para que sirve? 
        public ReportadorRankingDT ObtenerReportadorRanking(string id)
        {
            return valoracionreporte.ObtenerReportadorRanking(id);
        }

        [HttpGet]
        [Route("api/Ranking/ActualizarPuntos")]  // DR 10/07/2021: Ok
        public EstadoPerfilRankingDT ActualizarPuntos(string id, int puntosactuales)
        {
            EstadoPerfilRankingDT obj = new EstadoPerfilRankingDT()
            {
                puntosactuales = puntosactuales
            };
            return valoracionreporte.ActualizarPuntos(id, obj);
        }

        //RANKING GLOBAL
        [HttpGet]
        [Route("api/Ranking/ListarClasififacionNivel")] //DR10/07/2021: oK
        public IEnumerable<RankingGlobalDT> ListarClasififacionNivel()
        {
            return rankingglobal.ListarClasififacionNivel();
        }
    }
}
