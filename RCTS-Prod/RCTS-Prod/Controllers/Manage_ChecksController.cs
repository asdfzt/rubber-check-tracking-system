using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RCTS_Prod.Controllers
{
    public class Manage_ChecksController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}


