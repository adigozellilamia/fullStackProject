using Black_friday.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Black_friday.Models;
using System.IO;

namespace Black_friday.Controllers
{
    [entrance]
    public class userHomeController : Controller
    {
        Black_fridayEntities2 db = new Black_fridayEntities2();
        // GET: userHome
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Add()
        {
            

            if(Session["notgo"]!=null)
            {
                return RedirectToAction("index");
            }

            ViewBag.categorie = db.categories.ToList();
            ViewBag.name = db.group_products.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(group_products prd , description dsc , product pct , HttpPostedFileBase file, image img)
        {
            if (file == null)
            {
                Session["uploaderror"] = "your must select your file";
                return RedirectToAction("add");
            }
            if (file.ContentType != "image/png" && file.ContentType != "image/jpeg" && file.ContentType != "image/gif")
            {
                Session["uploaderror"] = "your file must be jpg,png or gif";
                return RedirectToAction("add");
            }
            if ((file.ContentLength / 1024) > 1024)
            {
                Session["uploaderror"] = "your file size must be max 1mb";
                return RedirectToAction("add");
            }
            string filename = DateTime.Now.ToString("ddmmyyyyhhmmssffff") + file.FileName;
            string path = Path.Combine(Server.MapPath("~/Upload"), filename);

            file.SaveAs(path);
            //about.photo = filename;
            
            img.name = filename;
            db.images.Add(img);
            db.descriptions.Add(dsc);
            
           // var x = db.group_products.FirstOrDefault(p => p.name == prd.name);
            product prdc = new product
            {
                description_id = dsc.id,
                name = prd.name,
               image_id=img.id
                
            };
            db.products.Add(prdc);
            db.SaveChanges();
            //return Content(usr.id.ToString());
            return RedirectToAction("add");
        }
    }
}