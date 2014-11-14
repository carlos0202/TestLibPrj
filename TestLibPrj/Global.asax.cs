using CommonTasksLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestLibPrj.App_Start;
using TestLibPrj.CustomCode;

namespace TestLibPrj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //User Configuration 
            HtmlLinksHelper.SetDelegate(Helpers.HasPermission);
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();   
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            
        }
    }
}
