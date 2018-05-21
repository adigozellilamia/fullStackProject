using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;

namespace Black_friday.Controllers
{
    public class LoginController : Controller
    {
        Black_fridayEntities2 db = new Black_fridayEntities2();
        // GET: Login
        public ActionResult Index()
        {

           
            return View();
        }
        public ActionResult logout()
        {
            Session["loginned"] = null;
            Session["notgo"] = null;
            return RedirectToAction("index", "home");
        }
        [HttpPost]
        public ActionResult Add(user usr)
        {

            db.users.Add(usr);
            db.SaveChanges();
            //return Content(usr.id.ToString());
            return RedirectToAction("index");
        }
        public ActionResult Entrance(user usr)
        {
            user loginned = db.users.FirstOrDefault(u => u.email == usr.email);

            if (loginned != null)
            {
                if (loginned.password == usr.password )
                {
                    if(loginned.type==0)
                    {
                        Session["loginned"] = true;
                        Session["usrid"] = loginned.id;
                        Session["notgo"] = loginned.type;
                        return RedirectToAction("index", "userHome");
                    }
                 
                    else
                {
                        Session["loginned"] = true;
                        Session["loginnedType"] = loginned.type;
                        Session["usrid"] = loginned.id;
                        return RedirectToAction("Add", "userHome");
                    }
                }
                
            }
            Session["LoginInvalid"] = true;
            return RedirectToAction("index");
        }
    }
}