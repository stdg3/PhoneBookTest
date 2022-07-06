using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sapecxTest.Models;

namespace sapecxTest.Controllers
{
    public class RegsController : Controller
    {
        private PhContext db = new PhContext();

        // GET: Regs
        public ActionResult Index()
        {
            var xRegs = db.xRegs.Include(r => r.Contact).Include(r => r.User);
            return View(xRegs.ToList());
        }

        // GET: Regs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regs regs = db.xRegs.Find(id);
            if (regs == null)
            {
                return HttpNotFound();
            }
            return View(regs);
        }

        // GET: Regs/Create
        public ActionResult Create()
        {
            ViewBag.ContactId = new SelectList(db.Contacts, "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserNic");
            return View();
        }

        // POST: Regs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegDate,UserId,ContactId")] Regs regs)
        {
            if (ModelState.IsValid)
            {
                db.xRegs.Add(regs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactId = new SelectList(db.Contacts, "Id", "Name", regs.ContactId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserNic", regs.UserId);
            return View(regs);
        }

        // GET: Regs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regs regs = db.xRegs.Find(id);
            if (regs == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactId = new SelectList(db.Contacts, "Id", "Name", regs.ContactId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserNic", regs.UserId);
            return View(regs);
        }

        // POST: Regs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RegDate,UserId,ContactId")] Regs regs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactId = new SelectList(db.Contacts, "Id", "Name", regs.ContactId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserNic", regs.UserId);
            return View(regs);
        }

        // GET: Regs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regs regs = db.xRegs.Find(id);
            if (regs == null)
            {
                return HttpNotFound();
            }
            return View(regs);
        }

        // POST: Regs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Regs regs = db.xRegs.Find(id);
            db.xRegs.Remove(regs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
