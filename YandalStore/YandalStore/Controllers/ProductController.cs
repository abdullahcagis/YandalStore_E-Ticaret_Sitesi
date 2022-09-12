using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Models;

namespace YandalStore.Controllers
{
    public class ProductController : Controller
    {
        Model1 db = new Model1();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            Product p = db.Products.Find(id);
            return View(p);
        }

        public ActionResult AddSepet(int? id)
        {
            if (id != null)
            {
                if (Session["user"] != null)
                {
                    UserCart uc = new UserCart();
                    uc.User_ID = ((User)Session["user"]).ID;
                    uc.Product_ID = Convert.ToInt32(id);
                    uc.Quantity = 1;
                    uc.CreationDate = DateTime.Now;
                    db.UserCarts.Add(uc);
                    db.SaveChanges();
                }
                else
                {
                    return RedirectToAction("Login", "User");
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}