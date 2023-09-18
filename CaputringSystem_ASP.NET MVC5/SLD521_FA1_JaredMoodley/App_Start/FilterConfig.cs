using System.Web;
using System.Web.Mvc;

namespace SLD521_FA1_JaredMoodley
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
