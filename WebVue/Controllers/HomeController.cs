using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.Title = "Registro";

            return View();
        }

        public ActionResult Listar()
        {
            ViewBag.Title = "Listar";

            return View();
        }
    }
}
