using System.Web;
using System.Web.Mvc;

namespace NguyenTienLong_1811060449_lab06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
