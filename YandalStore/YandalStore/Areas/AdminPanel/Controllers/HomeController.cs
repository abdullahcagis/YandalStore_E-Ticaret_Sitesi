using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YandalStore.Areas.AdminPanel.Filters;

namespace YandalStore.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class HomeController : Controller
    {
        // GET: AdminPanel/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}