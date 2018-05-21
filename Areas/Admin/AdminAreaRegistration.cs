﻿using System.Web.Mvc;

namespace Black_friday.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {controller= "home", action = "Index", id = UrlParameter.Optional },
                new []{ "Black_friday.Areas.Admin.Controllers" }
                );
        }
    }
}