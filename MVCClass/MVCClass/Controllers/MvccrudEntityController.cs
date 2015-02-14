using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClass.Controllers
{
    public class MvccrudEntityController : Controller
    {
        private PraArunMvcEntities db = new PraArunMvcEntities();

        //
        // GET: /MvccrudEntity/

        public ActionResult Index()
        {
            return View(db.Student.ToList());
        }

        //
        // GET: /MvccrudEntity/Details/5

        public ActionResult Details(int id = 0)
        {
            Student student = db.Student.Single(s => s.StudentId == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // GET: /MvccrudEntity/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MvccrudEntity/Create

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Student.AddObject(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        //
        // GET: /MvccrudEntity/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Student student = db.Student.Single(s => s.StudentId == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // POST: /MvccrudEntity/Edit/5

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Student.Attach(student);
                db.ObjectStateManager.ChangeObjectState(student, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //
        // GET: /MvccrudEntity/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Student student = db.Student.Single(s => s.StudentId == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // POST: /MvccrudEntity/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Student.Single(s => s.StudentId == id);
            db.Student.DeleteObject(student);
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