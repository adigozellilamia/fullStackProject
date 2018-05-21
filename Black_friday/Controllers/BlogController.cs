using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;

namespace Black_friday.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Black_fridayEntities2 db = new Black_fridayEntities2();
        public ActionResult Index()
        {
            ViewBag.BlogProduct = db.products.ToList().Where(p => p.name == "blog");
            return View();
        }

        public ActionResult Blog_details(int id)
        {
            ViewBag.trend_details = db.products.ToList().Where(p => p.name == "trend-details");
            ViewBag.trending = db.products.ToList().Where(p => p.name == "trend");
            ViewBag.blog = db.products.First(p => p.id == id);
            

            return View();
        }
    }
}