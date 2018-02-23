using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindApp.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Selecione o item que quer trabalhar";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
