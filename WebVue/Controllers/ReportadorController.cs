using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVue.Logica;

namespace WebVue.Controllers
{
    public class ReportadorController : Controller
    {
        private readonly LogicaReportador _logicaReportador;
        // GET: Reportador

        public ReportadorController()
        {
            _logicaReportador = new LogicaReportador();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarReportador()
        {
            var item = _logicaReportador.ListarReportador();

            JsonResult jsonres = Json(item, JsonRequestBehavior.AllowGet);

            return jsonres;
        }
    }


}