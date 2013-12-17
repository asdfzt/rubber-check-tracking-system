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
    public class Letter_TextsController : Controller
    {
        private RCTS_DatabaseContext db = new RCTS_DatabaseContext();

        //
        // GET: /Letter_Texts/

        public ActionResult Index()
        {
            return View(db.Letter_Texts.ToList());
        }

        //
        // GET: /Letter_Texts/Details/5

        public ActionResult Details(int id = 0)
        {
            Letter_Text letter_text = db.Letter_Texts.Find(id);
            if (letter_text == null)
            {
                return HttpNotFound();
            }
            return View(letter_text);
        }

        //
        // GET: /Letter_Texts/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Letter_Texts/Create

        [HttpPost]
        public ActionResult Create(Letter_Text letter_text)
        {
            if (ModelState.IsValid)
            {
                db.Letter_Texts.Add(letter_text);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(letter_text);
        }

        //
        // GET: /Letter_Texts/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Letter_Text letter_text = db.Letter_Texts.Find(id);
            if (letter_text == null)
            {
                return HttpNotFound();
            }
            return View(letter_text);
        }

        //
        // POST: /Letter_Texts/Edit/5

        [HttpPost]
        public ActionResult Edit(Letter_Text letter_text)
        {
            if (ModelState.IsValid)
            {
                db.Entry(letter_text).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(letter_text);
        }

        //
        // GET: /Letter_Texts/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Letter_Text letter_text = db.Letter_Texts.Find(id);
            if (letter_text == null)
            {
                return HttpNotFound();
            }
            return View(letter_text);
        }

        //
        // POST: /Letter_Texts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Letter_Text letter_text = db.Letter_Texts.Find(id);
            db.Letter_Texts.Remove(letter_text);
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