using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Models;

namespace YandalStore.Controllers
{
    public class CategoryController : Controller
    {
        Model1 db = new Model1();
        // GET: Category
        public ActionResult Index()
        {
            List<Category> categoryList = db.Categories.Where(x => x.Status == true).ToList();
            return View(categoryList);
        }
        public ActionResult kategoriDetay(int id)
        {
            List<Product> categoris = db.Products.Where(x => x.Category.ID == id).ToList();
            return View(categoris);
        }
    }
}