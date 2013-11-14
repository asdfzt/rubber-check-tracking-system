using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RCTS_Prod.Models;

namespace RCTS_Prod.Controllers
{
    public class ChecksController : Controller
    {
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();

        //
        // GET: /Checks/

        public ActionResult Index()
        {
            var checks = db.Checks.Include(c => c.Store).Include(c => c.Account);
            return View(checks.ToList());
        }

        //
        // GET: /Checks/Details/5

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

        public ActionResult Create()
        {
            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City");
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Routing_No");
            return View();
        }

        //
        // POST: /Checks/Create

        [HttpPost]
        public ActionResult Create(Check check)
        {
            if (ModelState.IsValid)
            {
                db.Checks.Add(check);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City", check.StoreID);
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Routing_No", check.Account_No);
            return View(check);
        }

        //
        // GET: /Checks/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Check check = db.Checks.Find(id);
            if (check == null)
            {
                return HttpNotFound();
            }
            ViewBag.StoreID = new SelectList(db.Stores, "StoreID", "Store_City", check.StoreID);
            ViewBag.Account_No = new SelectList(db.Accounts, "Account_No", "Routing_No", check.Account_No);
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
            return View(check);
        }

        //
        // GET: /Checks/Delete/5

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
        public ActionResult DeleteConfirmed(int id)
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
    }
}