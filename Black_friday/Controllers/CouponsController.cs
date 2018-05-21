using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;

namespace Black_friday.Controllers
{
   
    public class CouponsController : Controller

    {
        // GET: Coupons
        Black_fridayEntities2 db = new Black_fridayEntities2();
        public ActionResult Index()
        {
            ViewBag.coupons = db.products.ToList().Where(p => p.name == "coupons");
            
            return View();
        }
        public ActionResult Coupons_details(int id)
        {
            ViewBag.coupons = db.products.ToList().Where(p => p.name == "coupons");
            ViewBag.trend_details = db.products.ToList().Where(p => p.name == "trend-details");
            ViewBag.trending = db.products.ToList().Where(p => p.name == "trend");
            ViewBag.coupon = db.products.First(p => p.id == id);


            return View();
        }
    }
}