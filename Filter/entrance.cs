﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Black_friday.Filter
{
    public class entrance : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["loginned"] == null)
            {
                filterContext.Result = new RedirectResult("~/");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}