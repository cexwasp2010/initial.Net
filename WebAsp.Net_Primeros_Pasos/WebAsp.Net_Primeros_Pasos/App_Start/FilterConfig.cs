using System.Web;
using System.Web.Mvc;

namespace WebAsp.Net_Primeros_Pasos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
