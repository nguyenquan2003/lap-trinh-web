using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2001210779_NguyenNgocQuan_PC05.Models;
namespace _2001210779_NguyenNgocQuan_PC05.Controllers
{
    public class HomeController : Controller
    {
        ShopDTDDDataContext db = new ShopDTDDDataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TinTucPartial()
        {
            return View(db.LoaiTins.ToList());
        }
        public ActionResult LoaiPartial()
        {
            return View(db.Loais.ToList());
        }
        public ActionResult BannerPartial()
        {
            return View(db.Banners.ToList());
        }
    }
}
