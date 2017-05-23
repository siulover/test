using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.msg = "测试viewbag传递值";
            return View();
        }
        public string Default()
        {
            return "主页控制器";
        }
    }
}