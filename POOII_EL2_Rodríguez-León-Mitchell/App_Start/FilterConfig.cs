using System.Web;
using System.Web.Mvc;

namespace POOII_EL2_Rodríguez_León_Mitchell
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
