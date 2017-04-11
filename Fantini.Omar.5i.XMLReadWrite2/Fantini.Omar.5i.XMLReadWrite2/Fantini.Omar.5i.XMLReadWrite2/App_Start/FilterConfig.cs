using System.Web;
using System.Web.Mvc;

namespace Fantini.Omar._5i.XMLReadWrite2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
