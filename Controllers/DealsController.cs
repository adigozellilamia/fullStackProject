using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;

namespace Black_friday.Controllers
{
    public class DealsController : Controller
    {
        Black_fridayEntities2 db = new Black_fridayEntities2();
        // GET: Deals
        public ActionResult Index()
        {
            ViewBag.latestDeals = db.products.ToList().Where(p => p.name == "latest-deals");

            return View();
        }

        public ActionResult Deals_single(int id)
        {
            ViewBag.latest_deals = db.products.ToList().Where(p => p.name == "latest-deals");
            ViewBag.deals_single = db.products.ToList().Where(p => p.name == "deals-single");
            ViewBag.deals = db.products.First(p => p.id == id);
            return View();
        }
    }
}