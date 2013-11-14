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
    public class LettersController : Controller
    {
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();

        //
        // GET: /Letters/

        public ActionResult Index()
        {
            return View(db.Letters.ToList());
        }

        //
        // GET: /Letters/Details/5

        public ActionResult Details(int id = 0)
        {
            Letter letter = db.Letters.Find(id);
            if (letter == null)
            {
                return HttpNotFound();
            }
            return View(letter);
        }

        //
        // GET: /Letters/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Letters/Create

        [HttpPost]
        public ActionResult Create(Letter letter)
        {
            if (ModelState.IsValid)
            {
                db.Letters.Add(letter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(letter);
        }

        //
        // GET: /Letters/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Letter letter = db.Letters.Find(id);
            if (letter == null)
            {
                return HttpNotFound();
            }
            return View(letter);
        }

        //
        // POST: /Letters/Edit/5

        [HttpPost]
        public ActionResult Edit(Letter letter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(letter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(letter);
        }

        //
        // GET: /Letters/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Letter letter = db.Letters.Find(id);
            if (letter == null)
            {
                return HttpNotFound();
            }
            return View(letter);
        }

        //
        // POST: /Letters/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Letter letter = db.Letters.Find(id);
            db.Letters.Remove(letter);
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