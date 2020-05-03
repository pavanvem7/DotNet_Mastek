using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _25.Models;

namespace _25.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            var employee1 = db.Employee1.Include(e => e.Department);
            return View(employee1.ToList());
        }   
        
        public ActionResult EmployeesByDepartment()
        {
            var test1 = db.Employee1.Include("Department") 
                                        .GroupBy(x => x.Department.Name)
                                .Select(y => new DepartmentTotal
                                 {
                                     Name = y.Key,
                                     Total = y.Count()
                                 }).ToList().OrderByDescending(y => y.Total);
            return View(test1);
        }


        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee1 employee1 = db.Employee1.Find(id);
            if (employee1 == null)
            {
                return HttpNotFound();
            }
            return View(employee1);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name");
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,Name,Gender,City,DepartmentId")] Employee1 employee1)
        {
            if (ModelState.IsValid)
            {
                db.Employee1.Add(employee1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", employee1.DepartmentId);
            return View(employee1);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee1 employee1 = db.Employee1.Find(id);
            if (employee1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", employee1.DepartmentId);
            return View(employee1);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,Name,Gender,City,DepartmentId")] Employee1 employee1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", employee1.DepartmentId);
            return View(employee1);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee1 employee1 = db.Employee1.Find(id);
            if (employee1 == null)
            {
                return HttpNotFound();
            }
            return View(employee1);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee1 employee1 = db.Employee1.Find(id);
            db.Employee1.Remove(employee1);
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
