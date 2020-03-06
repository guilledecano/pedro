using EnC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Persona unapersona = new Persona();
            unapersona.edad = 25;
            unapersona.nombre = "pedro";
            return View(unapersona);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}