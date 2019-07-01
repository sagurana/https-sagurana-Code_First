using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Code_First_Demo.Model;
using Code_First_Demo.Repository;

namespace Code_First_Demo.Controllers
{
    public class MyTablesController : Controller
    {
        private CDBContext db = new CDBContext();

        // GET: MyTables
        public ActionResult Index()
        {
            return View(db.FirstTable.ToList());
        }

        // GET: MyTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTable myTable = db.FirstTable.Find(id);
            if (myTable == null)
            {
                return HttpNotFound();
            }
            return View(myTable);
        }

        // GET: MyTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMP_NO,EMP_FNAME,EMP_LNAME,EMP_DEPT")] MyTable myTable)
        {
            if (ModelState.IsValid)
            {
                db.FirstTable.Add(myTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myTable);
        }

        // GET: MyTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTable myTable = db.FirstTable.Find(id);
            if (myTable == null)
            {
                return HttpNotFound();
            }
            return View(myTable);
        }

        // POST: MyTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMP_NO,EMP_FNAME,EMP_LNAME,EMP_DEPT")] MyTable myTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myTable);
        }

        // GET: MyTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTable myTable = db.FirstTable.Find(id);
            if (myTable == null)
            {
                return HttpNotFound();
            }
            return View(myTable);
        }

        // POST: MyTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyTable myTable = db.FirstTable.Find(id);
            db.FirstTable.Remove(myTable);
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
