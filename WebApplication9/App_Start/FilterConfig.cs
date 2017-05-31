using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            //注册自定义Action过滤器，优先级最低，最高的为在Action中设置其过滤器
            filters.Add(new MyActionFilterAttribute() { Name = "测试在所有的Action中加入自定义过滤器" });
            filters.Add(new MyExceitionFilterAttribute());
        }
    }
}