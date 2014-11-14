using CommonTasksLib.Data;
using System.Web;
using System.Web.Mvc;
using TestLibPrj.Filters;

namespace TestLibPrj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(HtmlLinksHelper.Filter);
            filters.Add(new ManagedSessionFilterAttribute());
        }
    }
}
