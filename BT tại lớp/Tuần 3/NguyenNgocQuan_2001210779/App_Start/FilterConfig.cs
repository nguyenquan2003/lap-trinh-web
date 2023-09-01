using System.Web;
using System.Web.Mvc;

namespace NguyenNgocQuan_2001210779
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
