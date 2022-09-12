using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Models;
using YandalStore.Models.ViewModels;

namespace YandalStore.Controllers
{
    public class UserController : Controller
    {
        Model1 db = new Model1();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User u = db.Users.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                if (u != null)
                {
                    Session["user"] = u;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]       

        public ActionResult Signup(User user)
        {
            if(ModelState.IsValid)
            {
                user.CreationDate = DateTime.Now;
                user.Status = true;
                db.Users.Add(user);                
                db.SaveChanges();
                return RedirectToAction("Login", "User");                
            }
            return View(user);

        }
        
        public ActionResult Logout()
        {          
            Session.Remove("user");
            return RedirectToAction("Index", "Home");
        }
    }
}