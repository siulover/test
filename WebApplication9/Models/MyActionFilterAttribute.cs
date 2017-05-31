using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Models
{
    /// <summary>
    /// 自定义一个Action和ActionResult的过滤器，继承自System.Web.Mvc.ActionFilterAttribute类
    /// 该类是一个系统定义的一个过滤器类，是抽象类。其方法为虚方法，即未实现。
    /// 同时，MVC约定，过滤器类必须以Attribute结尾。约定大于规则。
    /// </summary>
    public class MyActionFilterAttribute:System.Web.Mvc.ActionFilterAttribute
    {
        public string Name { get; set; }

        /// <summary>
        /// Action执行之前会执行该方法
        /// </summary>
        /// <param name="filterContext">过滤器上下文</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //HttpContext.Current.Session[]
            base.OnActionExecuting(filterContext);
            //这里仅仅是为了展示，在实际开发中是需要写一些具体的业务逻辑处理的，例如：判断用户的登录状态，记录用户的操作日志等等。
            HttpContext.Current.Response.Write("<br />On Action Excuting:"+Name);
        }
        /// <summary>
        /// Action执行之后
        /// </summary>
        /// <param name="filterContext">过滤器上下文</param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            HttpContext.Current.Response.Write("<br />OnActionExecuted ：" + Name);
        }

        /// <summary>
        /// ActionResult执行之前先执行此方法
        /// </summary>
        /// <param name="filterContext">过滤器上下文</param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            HttpContext.Current.Response.Write("<br />OnResultExecuting ：" + Name);

        }

        /// <summary>
        /// ActionResult执行之后先执行此方法
        /// </summary>
        /// <param name="filterContext">过滤器上下文</param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            HttpContext.Current.Response.Write("<br />OnResultExecuted ：" + Name);
        }
    }
}