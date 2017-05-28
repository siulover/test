﻿using System.Web.Mvc;

namespace WebApplication9.Areas.Test
{
    public class TestAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Test";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Test_default",
                "Test/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
                ,namespaces:new string[] { "WebApplication9.Areas.Test.Controllers" }
            );
        }
    }
}