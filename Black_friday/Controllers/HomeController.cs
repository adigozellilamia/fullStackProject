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

           
            ViewBag.blogProduct = db.products.ToList().Where(p => p.group_products.name == "blog");
            ViewBag.couponsProduct = db.products.ToList().Where(p => p.group_products.name == "coupons");
            ViewBag.saleProduct = db.sales.ToList().Where(p => p.group_sale.name == "black-friday");
            ViewBag.latest_dealsProduct = db.products.ToList().Where(p => p.group_products.name == "latest-deals");
            ViewBag.trendingProduct = db.products.ToList().Where(p => p.group_products.name == "trend");
            ViewBag.partners = db.images.ToList().Where(p => p.page == "partners");
            ViewBag.popular = db.images.ToList().Where(p => p.page == "popular");
          
            return View();
        }

        
    }
}