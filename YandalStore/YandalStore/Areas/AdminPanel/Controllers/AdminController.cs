using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Areas.AdminPanel.Filters;
using YandalStore.Models;

namespace YandalStore.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class AdminController : Controller
    {
        Model1 db = new Model1();
        // GET: AdminPanel/Admin
        public ActionResult Index()
        {
            List<Manager> managers = db.Managers.ToList();
            return View(managers);
        }
        [HttpGet]
        public ActionResult EditManager(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Manager manager = db.Managers.Find(id);
            return View(manager);
        }
        [HttpPost]
        public ActionResult EditManager(Manager model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                model.CreationDate = DateTime.Now;
                model.ManagerType_ID = 1;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}