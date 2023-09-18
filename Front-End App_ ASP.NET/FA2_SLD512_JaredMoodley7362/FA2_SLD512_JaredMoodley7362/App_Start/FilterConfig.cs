using System.Web;
using System.Web.Mvc;

namespace FA2_SLD512_JaredMoodley7362
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
