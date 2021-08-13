using System.Web;
using System.Web.Mvc;

namespace Dynamic_Model_to_View_Multiple_Model_in_Single_View
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
