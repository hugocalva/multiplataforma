using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Manual_inicioUTTT.Models;

namespace Manual_inicioUTTT.Controllers
{
    public class holaController : Controller
    {
        private ITLACursosEntities db = new ITLACursosEntities();
        // GET: hola
        public ActionResult Index()
        {
            return View(db.Curso.ToList());
        }

        // GET: hola/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Curso.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: hola/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hola/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: hola/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: hola/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: hola/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: hola/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
