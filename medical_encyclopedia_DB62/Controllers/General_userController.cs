using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using medical_encyclopedia_DB62.Models;

namespace medical_encyclopedia_DB62.Controllers
{
    public class General_userController : Controller
    {
        private medical_encylopediaEntities db = new medical_encylopediaEntities();

        // GET: General_user
        public ActionResult Index()
        {
            return View(db.General_user.ToList());
        }

        // GET: General_user/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            General_user general_user = db.General_user.Find(id);
            if (general_user == null)
            {
                return HttpNotFound();
            }
            return View(general_user);
        }

        // GET: General_user/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: General_user/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user_id,Name,Password,Email,Contact_number,CNIC,Address,Country")] General_user general_user)
        {
            if (ModelState.IsValid)
            {
                db.General_user.Add(general_user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(general_user);
        }

        // GET: General_user/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            General_user general_user = db.General_user.Find(id);
            if (general_user == null)
            {
                return HttpNotFound();
            }
            return View(general_user);
        }

        // POST: General_user/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user_id,Name,Password,Email,Contact_number,CNIC,Address,Country")] General_user general_user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(general_user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(general_user);
        }

        // GET: General_user/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            General_user general_user = db.General_user.Find(id);
            if (general_user == null)
            {
                return HttpNotFound();
            }
            return View(general_user);
        }

        // POST: General_user/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            General_user general_user = db.General_user.Find(id);
            db.General_user.Remove(general_user);
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
