using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Models;

namespace YandalStore.Controllers
{
    public class FavoriteController : Controller
    {
        Model1 db = new Model1();
        // GET: Favorite
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                int id = ((User)Session["user"]).ID;
                return View(db.Favorites.Where(x => x.User_ID == id).ToList());
            }
            return RedirectToAction("Login", "User");
        }
        public ActionResult Add(int? id, int? adet)
        {
            if (id != null)
            {
                if (Session["user"] != null)
                {
                    Favorite fvr = db.Favorites.FirstOrDefault(x => x.Product_ID == id);
                    if (fvr == null)
                    {
                        Favorite fv = new Favorite();
                        fv.User_ID = ((User)Session["user"]).ID;
                        fv.Product_ID = Convert.ToInt32(id);
                        fv.Quantity = adet ?? 1;
                        fv.CreationDate = DateTime.Now;
                        db.Favorites.Add(fv);
                        db.SaveChanges();
                    }
                    else
                    {
                        fvr.Quantity = fvr.Quantity + (adet ?? 1);
                        db.SaveChanges();
                    }
                }
                else
                {
                    return RedirectToAction("Login", "User");
                }
            }
            return RedirectToAction("Index", "Home");
        }


        public ActionResult DeleteFavorite(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            Favorite fv = db.Favorites.Find(id);
            db.Favorites.Remove(fv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}