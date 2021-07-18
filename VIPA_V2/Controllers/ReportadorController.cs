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

    public class ReportadorController : ApiController
    {
        [HttpGet]
        [Route("api/Reportador/RegistroReportador")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public ReportadorDT RegistroReportador(String aliasusuario, String nombrereportador, String apellidosreportador, String correoreportador, String contraseniareportador)
        {
            //Function to save data in the DB
            ReportadorDT obj = new ReportadorDT()
            {
                aliasusuario = aliasusuario,
                nombrereportador = nombrereportador,
                apellidosreportador = apellidosreportador,
                correoreportador = correoreportador,
                contraseniareportador = contraseniareportador,

            };

            return reportador.IngresarReportador(obj);
        }
        [HttpGet]
        [Route("api/Cliente/ListarReportador")] //DR 10/07/2021: Ok
        public IEnumerable<ReportadorDT2> ListarReportador()
        {
            return reportador.ListarReportador();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Reportador/Login")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public ReportadorDT loginreportadorform(String correoreportador, String contraseniareportador)
        {
            //Function to save data in the DB
            var cor = correoreportador;
            var con = contraseniareportador;
            return reportador.LoginReportador(cor, con);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Reportador/verificarcodigo")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public bool verificarcodigo(String id, String codigo)
        {
            return reportador.verificacodigo(id, codigo);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Reportador/updateperfilverificar")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public bool updateperfilverificar(String id)
        {
            //Function to save data in the DB
            var cor = id;
            return reportador.verificarperfil(cor);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Reportador/CuentaVerificada")] //DR 10/07/2021: Aún no lo pruebo. Espero FRONT
        public bool CuentaVerificada([FromBody] cuentaverificada request)
        {
            //Function to save data in the DB
            return reportador.CuentaVerificada(request);
        }
    }
}
