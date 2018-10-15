using Examen.Models;
using Examen.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class EmployController : Controller
    {
        private DBExamen db = new DBExamen();

        // GET: Employ
        public ActionResult Index(string NameString)
        {
            if(NameString != "" && NameString != null)
            {
                return View(db.Employ.Where(w=>w.Name.Contains(NameString)).OrderBy(x => x.Name));
            }
            else
            {
                return View(db.Employ.OrderBy(x => x.Name));
            }
        }

        // GET: Employ/Create
        public ActionResult Create()
        {
            EmployDeparmentViewModel _employDeparment = new EmployDeparmentViewModel();

            _employDeparment.Departments = db.Department.ToList();

            return View(_employDeparment);
        }

        // POST: Employ/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Employ _employ = new Employ();
                _employ.Name = collection["Employ.Name"];
                _employ.LastName = collection["Employ.LastName"];
                _employ.PhoneNumber = collection["Employ.PhoneNumber"];
                _employ.Email = collection["Employ.Email"];
                _employ.IdDepartment = Convert.ToInt32(collection["Department"]);

                db.Employ.Add(_employ);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employ/Edit/5
        public ActionResult Edit(int? id)
        {
            //return View(db.Employ.Find(id));

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employ _employ = db.Employ.Find(id);
            if (_employ == null)
            {
                return HttpNotFound();
            }

            EmployDeparmentViewModel _employDeparment = new EmployDeparmentViewModel();

            _employDeparment.Employ = _employ;
            _employDeparment.Departments = db.Department.ToList();

            return View(_employDeparment);
        }

        // POST: Employ/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                int id = Convert.ToInt32(collection["Employ.IdEmploy"]);
                Employ _employ = db.Employ.Find(id);

                _employ.Name = collection["Employ.Name"];
                _employ.LastName = collection["Employ.LastName"];
                _employ.PhoneNumber = collection["Employ.PhoneNumber"];
                _employ.Email = collection["Employ.Email"];
                _employ.IdDepartment = Convert.ToInt32(collection["Department.IdDepartment"]);

                db.SaveChanges();

            return RedirectToAction("Index");
            }
            catch
            {
                return View();
                }
        }
    }
}