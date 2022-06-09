using System.Web;
using System.Web.Mvc;

namespace Day4Custom_Helpers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
