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
    public class AccountsController : Controller
    {
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();

        //
        // GET: /Accounts/

        public ActionResult Index()
        {
            var accounts = db.Accounts.Include(a => a.Bank);
            return View(accounts.ToList());
        }

        //
        // GET: /Accounts/Details/5

        public ActionResult Details(string id = null)
        {
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        //
        // GET: /Accounts/Create

        public ActionResult Create()
        {
            ViewBag.Routing_No = new SelectList(db.Banks, "Routing_No", "Bank_Phone_No");
            return View();
        }

        //
        // POST: /Accounts/Create

        [HttpPost]
        public ActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Routing_No = new SelectList(db.Banks, "Routing_No", "Bank_Phone_No", account.Routing_No);
            return View(account);
        }

        //
        // GET: /Accounts/Edit/5

        public ActionResult Edit(string id = null)
        {
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            ViewBag.Routing_No = new SelectList(db.Banks, "Routing_No", "Bank_Phone_No", account.Routing_No);
            return View(account);
        }

        //
        // POST: /Accounts/Edit/5

        [HttpPost]
        public ActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Routing_No = new SelectList(db.Banks, "Routing_No", "Bank_Phone_No", account.Routing_No);
            return View(account);
        }

        //
        // GET: /Accounts/Delete/5

        public ActionResult Delete(string id = null)
        {
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        //
        // POST: /Accounts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Account account = db.Accounts.Find(id);
            db.Accounts.Remove(account);
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