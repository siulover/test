using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Models
{
    public class MyExceitionFilterAttribute: System.Web.Mvc.HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            //出现异常转到首页，这里是一个测试，没有对异常进行处理。在实际开发中，需要获取异常对象，并将其记录至日志中。
            HttpContext.Current.Response.Redirect("/Home/Index");

            //例如，下面一段代码：
            //获取系统异常消息记录
            //string strException = filterContext.Exception.Message;
            //if (!string.IsNullOrEmpty(strException))
            //{
            //    //使用Log4Net记录异常信息
            //    Exception exception = filterContext.Exception;
            //    if (exception != null)
            //    {
            //        LogHelper.WriteErrorLog(strException, exception);
            //    }
            //    else
            //    {
            //        LogHelper.WriteErrorLog(strException);
            //    }
            //}

            //filterContext.HttpContext.Response.Redirect("~/GlobalErrorPage.html");
        }
    }
}