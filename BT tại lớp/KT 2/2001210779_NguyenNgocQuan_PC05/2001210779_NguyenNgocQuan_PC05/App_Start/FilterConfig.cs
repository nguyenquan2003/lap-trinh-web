using System.Web;
using System.Web.Mvc;

namespace _2001210779_NguyenNgocQuan_PC05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
