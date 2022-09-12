using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Areas.AdminPanel.Model.ViewModels;
using YandalStore.Models;

namespace YandalStore.Areas.AdminPanel.Controllers
{
    public class ManagerLoginController : Controller
    {
        // GET: AdminPanel/ManagerLogin
        Model1 db = new Model1();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(AdminLoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(db.Managers.Count(x => x.Mail == model.Mail && x.Password == model.Password) > 0)
                {
                    Manager m = db.Managers.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                    Session["manager"] = m;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        
        public ActionResult Out()
        {
            Session.Remove("manager");
            return RedirectToAction("Login", "ManagerLogin");
        }
        
    }
}