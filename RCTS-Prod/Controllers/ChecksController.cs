using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RCTS_Prod.Models;

namespace RCTS_Prod.Controllers
{   [Authorize]
    public class ChecksController : Controller
    {
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();
        private static Check TheCheck;
        public static IEnumerable<RCTS_Prod.Models.Check> LettersToPrint;
        //
        // GET: /Checks/
        [Authorize]
        public ActionResult Index()
        {

            
            return View();
        }

        //
        // GET: /Checks/Details/5
        [Authorize]
        public ActionResult Details(int id = 0)
        {
            Check check = db.Checks.Find(id);
            if (check == null)
            {
                return HttpNotFound();
            }
            return View(check);
        }

        //
        // GET: /Checks/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City");
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Account_No");
            ViewBag.Check_PasserID = new SelectList(db.Check_Passers, "Check_PasserID", "Check_PasserID");
            return View();
        }

        //
        // POST: /Checks/Create

        [HttpPost]
        public ActionResult Create(Check check)
        {
            if (ModelState.IsValid)
            {
                check.Date_Payment_Received = check.Date_Check_Received;
                check.Fee_Received = 0;
                check.Letter_Text_ID = 1;
                check.Letter_One_Received = Convert.ToDateTime("12/12/12");
                check.Letter_One_Sent = Convert.ToDateTime("12/12/12");
                check.Letter_Two_Received = Convert.ToDateTime("12/12/12");
                check.Letter_Two_Sent = Convert.ToDateTime("12/12/12");
                check.Letter_Three_Received = Convert.ToDateTime("12/12/12");
                check.Letter_Three_Sent = Convert.ToDateTime("12/12/12");

                db.Checks.Add(check);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City", check.StoreID);
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Routing_No", check.Account_No);
            ViewBag.Check_PasserID = new SelectList(db.Check_Passers, "Check_PasserID", "Last_Name", check.Check_PasserID);
            return View(check);
        }

        //
        // GET: /Checks/Edit/5
        [Authorize(Users=("ahughes, ztaylor"))]
        public ActionResult Edit(int id = 0)
        {
            Check check = db.Checks.Find(id);
            if (check == null)
            {
                return HttpNotFound();
            }
            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City", check.StoreID);
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Routing_No", check.Account_No);
            ViewBag.Check_PasserID = new SelectList(db.Check_Passers, "Check_PasserID", "Last_Name", check.Check_PasserID);
            return View(check);
        }

        //
        // POST: /Checks/Edit/5

        [HttpPost]
        public ActionResult Edit(Check check)
        {
            if (ModelState.IsValid)
            {
                db.Entry(check).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City", check.StoreID);
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Routing_No", check.Account_No);
            ViewBag.Check_PasserID = new SelectList(db.Check_Passers, "Check_PasserID", "Last_Name", check.Check_PasserID);
            return View(check);
        }

        //
        // GET: /Checks/Delete/5
        [Authorize(Users="ahughes, ztaylor")]
        public ActionResult Delete(int id = 0)
        {
            Check check = db.Checks.Find(id);
            if (check == null)
            {
                return HttpNotFound();
            }
            return View(check);
        }

        //
        // POST: /Checks/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id=0)
        {
            Check check = db.Checks.Find(id);
            db.Checks.Remove(check);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult EnterFee(int id=0)
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.ch = TheCheck;
            return View(TheCheck);
        }

        [HttpPost]
        public ActionResult EnterFee(string date)
        {
            try
            {
                TheCheck.Letter_One_Sent = System.Convert.ToDateTime(date);
            }
            catch
            {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("PrintLetters");
        }

        public ActionResult Open()
        {
            var checks = db.Checks.Include(c => c.Store).Include(c => c.Check_Passer).Include(c => c.Account);
            var OpenChecks =
                from c in checks
                where c.Date_Payment_Received == c.Date_Check_Received && c.Amount > c.Fee_Received
                select c;
            return View(OpenChecks.ToList());
        }


        public ActionResult Close()
        {
            var checks = db.Checks.Include(c => c.Store).Include(c => c.Check_Passer).Include(c => c.Account);
            var ClosedChecks =
                from c in checks
                where c.Date_Payment_Received != c.Date_Check_Received
                select c;
            return View(ClosedChecks.ToList());
        }

        public ActionResult All(int sort=0)
        {
            var checks = db.Checks;
            var SortedChecks =
                from c in checks
                select c;
            
            if (sort == 1){
                SortedChecks =
                from c in checks
                orderby c.Check_Passer.Last_Name
                select c;
            }
            else if (sort == 2) {
                SortedChecks =
                from c in checks
                orderby c.Check_No
                select c;
            }
            else if (sort == 3)
            {
                SortedChecks =
                from c in checks
                orderby c.Date_Check_Received
                select c;
            }
            else if (sort == 4)
            {
                SortedChecks =
                from c in checks
                orderby c.Amount
                select c;
            }
            else if (sort == 5)
            {
                SortedChecks =
                from c in checks
                orderby c.Date_Payment_Received
                select c;
            }
            else if (sort == 6)
            {
                SortedChecks =
                from c in checks
                orderby c.Fee_Received
                select c;
            }
            
            
            
            return View(SortedChecks.ToList());
        }

        public ActionResult Let1SentUpdate(int id=0)
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.id = TheCheck.Letter_Text_ID;
            return View(TheCheck);
        }



        [HttpPost]
        public ActionResult Let1SentUpdate(string date)
        {
            try
            {
                TheCheck.Letter_One_Sent = System.Convert.ToDateTime(date);
            }
            catch {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("PrintLetters");
        }

        public ActionResult Let2SentUpdate(int id = 0)
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.id = TheCheck.Letter_Text_ID;
            return View(TheCheck);
        }



        [HttpPost]
        public ActionResult Let2SentUpdate(string date)
        {
            try
            {
                TheCheck.Letter_Two_Sent = System.Convert.ToDateTime(date);
            }
            catch
            {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            TheCheck.Letter_Text_ID = TheCheck.Letter_Text_ID + 1;
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("PrintLetters");
        }



        public ActionResult Let3SentUpdate(int id = 0)
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.id = TheCheck.Letter_Text_ID;
            return View(TheCheck);
        }



        [HttpPost]
        public ActionResult Let3SentUpdate(string date)
        {
            try
            {
                TheCheck.Letter_Three_Sent = System.Convert.ToDateTime(date);
            }
            catch
            {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            TheCheck.Letter_Text_ID = TheCheck.Letter_Text_ID + 1;
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("PrintLetters");
        }


        public ActionResult Let1RecUpdate(int id = 0) 
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.id = TheCheck.Letter_Text_ID;
            return View(TheCheck);
        }



        [HttpPost]
        public ActionResult Let1RecUpdate(string date)
        {
            try
            {
                TheCheck.Letter_One_Received = System.Convert.ToDateTime(date);
            }
            catch
            {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            TheCheck.Letter_Text_ID = TheCheck.Letter_Text_ID + 1;
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Open");
        }



        public ActionResult Let2RecUpdate(int id = 0)
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.id = TheCheck.Letter_Text_ID;
            return View(TheCheck);
        }



        [HttpPost]
        public ActionResult Let2RecUpdate(string date)
        {
            try
            {
                TheCheck.Letter_Two_Received = System.Convert.ToDateTime(date);
            }
            catch
            {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            TheCheck.Letter_Text_ID = TheCheck.Letter_Text_ID + 1;
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Open");
        }


        public ActionResult Let3RecUpdate(int id = 0)
        {
            TheCheck = db.Checks.Find(id);
            ViewBag.id = TheCheck.Letter_Text_ID;
            return View(TheCheck);
        }



        [HttpPost]
        public ActionResult Let3RecUpdate(string date)
        {
            try
            {
                TheCheck.Letter_Three_Received = System.Convert.ToDateTime(date);
            }
            catch
            {
                ViewBag.message = "Incorrect Date, must be in the format: {Month}/{Day}/{Yeaer}";
                return View();
            }
            TheCheck.Letter_Text_ID = TheCheck.Letter_Text_ID + 1;
            db.Entry(TheCheck).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Open");
        }

       

        [Authorize]
        public ActionResult PrintLetters()
        {
            var checks = db.Checks.ToList();
            ViewBag.Letters = checks;



            var Letter1ToPrint =
                from c in checks
                where c.Letter_Text_ID == 1 && (c.Letter_One_Sent == Convert.ToDateTime("12/12/12") && c.Letter_One_Received == Convert.ToDateTime("12/12/12"))
                select c;

            var Letter2ToPrint =
                from c in checks
                where c.Letter_Text_ID == 2 && (c.Letter_One_Received.AddDays(14) <= DateTime.Now)
                select c;

            var Letter3ToPrint =
                from c in checks
                where c.Letter_Text_ID == 3 && (c.Letter_Two_Received.AddDays(14) <= DateTime.Now)
                select c;

            LettersToPrint = Letter1ToPrint.Concat(Letter2ToPrint).Concat(Letter3ToPrint);

            //foreach (var i in LettersToPrint.ToList()) {
            //    if (!LetToPrintArray.Contains(i.CheckID.ToString()))
            //        LetToPrintArray.Add(i.CheckID.ToString());
            //}

            //var CheckstoPrint = db.Checks.Include(c => c.Check_Passer)
            //ViewBag.Checks = CheckstoPrint;

            return View(LettersToPrint.ToList());
        }
        [Authorize]
        public ActionResult Letter1(int id = 0)
        {
            Check check = db.Checks.Find(id);
            ViewBag.ch = check;
            return View();
        }
        [Authorize]
        public ActionResult Letter2(int id = 0)
        {
            Check check = db.Checks.Find(id);

            ViewBag.ch = check;
            return View();
        }
        [Authorize]
        public ActionResult Letter3(int id = 0)
        {
            Check check = db.Checks.Find(id);

            ViewBag.ch = check;
            return View();
        }
        [Authorize]
        public ActionResult PrintAll()
        {

            return View(LettersToPrint);
        }

    }
}