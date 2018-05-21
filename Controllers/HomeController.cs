using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;

namespace Black_friday.Controllers
{
    public class HomeController : Controller
    {
        Black_fridayEntities2 db = new Black_fridayEntities2();
        public ActionResult Index()
        {
            ViewBag.category = db.categories.ToList();

            ViewBag.blogProduct = db.products.ToList().Where(p => p.name == "blog");
            ViewBag.couponsProduct = db.products.ToList().Where(p => p.name == "coupons");
            ViewBag.partners = db.images.ToList().Where(p => p.page == "partners");
            ViewBag.saleProduct = db.sales.ToList().Where(p => p.name == "black-friday");
            ViewBag.latest_dealsProduct = db.products.ToList().Where(p => p.name == "latest-deals");
            ViewBag.popular = db.images.ToList().Where(p => p.page == "popular");
            ViewBag.trendingProduct = db.products.ToList().Where(p => p.name == "trend");
            return View();
        }

        
    }
}