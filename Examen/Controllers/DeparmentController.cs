using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class DeparmentController : Controller
    {
        private DBExamen db = new DBExamen();
        // GET: Deparment
        public ActionResult Index()
        {
            return View(db.Department.ToList());
        }

        // GET: Deparment/Details/5
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deparment/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Department _department = new Department();
                _department.Name = collection["Name"];
                db.Department.Add(_department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Deparment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department _department = db.Department.Find(id);
            if (_department == null)
            {
                return HttpNotFound();
            }
            return View(_department);
        }

        // POST: Deparment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDepartment,Name")] Department deparment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(deparment).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
        }
            return View(deparment);
        }
    }
}
