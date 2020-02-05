using System.Web;
using System.Web.Mvc;

namespace ASP.Net.Base._1.Shop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
