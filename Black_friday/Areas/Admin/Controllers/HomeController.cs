using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;
using System.Web.Helpers;

namespace Black_friday.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        Black_fridayEntities2 db = new Black_fridayEntities2();
        // GET: Admin/Home
        public ActionResult Index()
        {

            return View();
            

        }
        [HttpPost]

        public ActionResult Login(user_admin usr)
        {
            user_admin loginned = db.user_admin.FirstOrDefault(u => u.email == usr.email);
            if (loginned != null)
            {
                if (Crypto.VerifyHashedPassword(loginned.password, usr.password))
                {
                    Session["loginned"] = true;
                    Session["usrid"] = loginned.id;
                    return RedirectToAction("index", "dashboard");
                }
            }
            Session["LoginInvalid"] = true;
            return RedirectToAction("index");
        }
    }
}