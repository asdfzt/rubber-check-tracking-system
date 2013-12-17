using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using RCTS_Prod.Models;

namespace RCTS_Prod.Controllers
{
    [Authorize(Users="ztaylor, ahughes")]
    public class Admin_DutiesController : Controller
    {
        public Admin_DutiesController() { 
            System.IO.StreamReader myFile =
            new System.IO.StreamReader("C:\\inetpub\\wwwroot\\App_Data\\test.txt");
            AdminStr = myFile.ReadToEnd();
            myFile.Close();
        }
        private static string AdminStr;
            
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();
        
       
        
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

        public ActionResult Reports()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reports(string fromDate = "", string toDate = "")
        {
            DateTime fdate;
            DateTime tdate;
            try
            {
                fdate = System.Convert.ToDateTime(fromDate);
                tdate = System.Convert.ToDateTime(toDate);
            }
            catch
            {
                return View();
            }

            IEnumerable<RCTS_Prod.Models.Check> view =
                from c in db.Checks
                where c.Date_Check_Received >= fdate && c.Date_Check_Received <= tdate
                select c;

            return View(view.ToList());
            
        }
        
    }
}