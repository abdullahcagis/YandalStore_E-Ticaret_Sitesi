using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Models;

namespace YandalStore.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Shop()
        {
            List<Product> ProductList = db.Products.Where(s => s.SellStatus == true).ToList();
            return View(ProductList);
        }
    }
}