using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RCTS_Prod.Controllers
{
    //Controller for the home page
    public class HomeController : Controller
    {
        //calls the default view for the home page
        public ActionResult Index()
        {
            ViewBag.Message = "This is the Default page";

            return View();
        }
        //calls the about view 
        public ActionResult About()
        {
            ViewBag.Message = "This is the About page";

            return View();
        }
        
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "This is the Contact page";

        //    return View();
        //}
    }
}
