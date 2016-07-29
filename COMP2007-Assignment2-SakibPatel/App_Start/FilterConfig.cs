using System.Web;
using System.Web.Mvc;

namespace COMP2007_Assignment2_SakibPatel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
