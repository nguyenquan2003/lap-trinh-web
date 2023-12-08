using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2001210779_NguyenNgocQuan_PC05.Models;
namespace _2001210779_NguyenNgocQuan_PC05.Controllers
{
    public class TinTucController : Controller
    {
        ShopDTDDDataContext db = new ShopDTDDDataContext();

        // GET: TinTuc
        public ActionResult TinTuc()
        {
            return View(db.TinTucs.ToList());
        }
        public ActionResult TinTucTheoLoai(int MLTin)
        {
            //var sp = db.TinTucs.Where(s => s.MaTin == matin).ToList();
            //int sl = db.TinTucs.Count(s => s.MaTin == matin);
            //if (sl == null)
            //{
            //    ViewBag.TB = "Không có tin tức nào thuộc loại này!";
            //}
            //else
            //{
            //    ViewBag.TB = null;
            //}
            return View(db.TinTucs.Where(s => s.MLTin == MLTin).ToList());
        }
    }
}