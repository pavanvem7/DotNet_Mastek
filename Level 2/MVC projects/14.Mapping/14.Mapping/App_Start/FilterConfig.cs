using System.Web;
using System.Web.Mvc;

namespace _81.Bussiness_Object
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
