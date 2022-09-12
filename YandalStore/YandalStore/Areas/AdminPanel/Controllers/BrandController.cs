using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YandalStore.Areas.AdminPanel.Filters;
using YandalStore.Models;

namespace YandalStore.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class BrandController : Controller
    {
        
        // GET: AdminPanel/Brand
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            return View(db.Brands.ToList());
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            Brand brand = db.Brands.Find(id);
            if(brand == null)
            {
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "ID, Name, Status")] Brand brand)
        {
            if(ModelState.IsValid)
            {
                db.Brands.Add(brand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            Brand brand = db.Brands.Find(id);
            if( brand == null)
            {
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind(Include = "ID,Name,status")] Brand brand)
        {
            if(ModelState.IsValid)
            {
                db.Entry(brand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = db.Brands.Find(id);
            if(brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            Brand brand = db.Brands.Find(id);
            db.Brands.Remove(brand);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}