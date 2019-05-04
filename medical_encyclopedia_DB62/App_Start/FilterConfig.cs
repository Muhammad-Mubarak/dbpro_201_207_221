using System.Web;
using System.Web.Mvc;

namespace medical_encyclopedia_DB62
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
