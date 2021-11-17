using System.Web;
using System.Web.Mvc;

namespace Demo005_Mangas_ApiRest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
