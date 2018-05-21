using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Filter;

namespace Black_friday.Areas.Admin.Controllers
{
    [auth]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()

        {
            
            return View();
        }
    }
}