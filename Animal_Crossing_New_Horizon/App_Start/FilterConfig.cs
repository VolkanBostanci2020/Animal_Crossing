using System.Web;
using System.Web.Mvc;

namespace Animal_Crossing_New_Horizon
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
