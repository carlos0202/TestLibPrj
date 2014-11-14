using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestLibPrj.Filters
{
    public class ManagedSessionFilterAttribute : ActionFilterAttribute
    {
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    HttpContext ctx = HttpContext.Current;
        //    string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
        //    if (!controllerName.Contains("account"))
        //    {
        //        // check if session is supported
        //        if (ctx.Session != null)
        //        {
        //            // check if a new session id was generated
        //            if (ctx.Session.IsNewSession)
        //            {
        //                // If it says it is a new session, but an existing cookie exists, then it must
        //                // have timed out
        //                string sessionCookie = ctx.Request.Headers["Cookie"];
        //                if ((null != sessionCookie) && (sessionCookie.IndexOf("ASP.NET_SessionId") >= 0))
        //                {
        //                    filterContext.Result = new RedirectToRouteResult(
        //                         new RouteValueDictionary
        //                     {
        //                         { "controller", "Account" },
        //                         { "action", "Login" }
        //                     });
        //                }
        //            }
        //        }
        //    }
        //    base.OnActionExecuting(filterContext);
        //}

        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
        //    if (!controllerName.Contains("account"))
        //    {
        //        HttpSessionStateBase session = filterContext.HttpContext.Session;
        //        var user = session["UserName"]; //Key 2 should be User or UserName
        //        if (((user == null) && (!session.IsNewSession)) || (session.IsNewSession))
        //        {
        //            //send them off to the login page
        //            var url = new UrlHelper(filterContext.RequestContext);
        //            var loginUrl = url.Content("~/Account/Login");
        //            filterContext.HttpContext.Response.Redirect(loginUrl, true);
        //        }
        //    }
        //}
    }
}