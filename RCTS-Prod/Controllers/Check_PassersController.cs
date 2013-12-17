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
    public class Check_PassersController : Controller
    {
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();

        //
        // GET: /Check_Passers/

        public ActionResult Index()
        {
            return View(db.Check_Passers.ToList());
        }

        //
        // GET: /Check_Passers/Details/5

        public ActionResult Details(int id = 0)
        {
            Check_Passer check_passer = db.Check_Passers.Find(id);
            if (check_passer == null)
            {
                return HttpNotFound();
            }
            return View(check_passer);
        }

        //
        // GET: /Check_Passers/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Check_Passers/Create

        [HttpPost]
        public ActionResult Create(Check_Passer check_passer)
        {
            if (ModelState.IsValid)
            {
                db.Check_Passers.Add(check_passer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(check_passer);
        }

        //
        // GET: /Check_Passers/Edit/5

        public ActionResult Edit(string id="")
        {
            Check_Passer check_passer = db.Check_Passers.Find(id);
            if (check_passer == null)
            {
                return HttpNotFound();
            }
            return View(check_passer);
        }

        //
        // POST: /Check_Passers/Edit/5

        [HttpPost]
        public ActionResult Edit(Check_Passer check_passer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(check_passer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(check_passer);
        }

        //
        // GET: /Check_Passers/Delete/5

        public ActionResult Delete(string id = "")
        {
            Check_Passer check_passer = db.Check_Passers.Find(id);
            if (check_passer == null)
            {
                return HttpNotFound();
            }
            return View(check_passer);
        }

        //
        // POST: /Check_Passers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Check_Passer check_passer = db.Check_Passers.Find(id);
            db.Check_Passers.Remove(check_passer);
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