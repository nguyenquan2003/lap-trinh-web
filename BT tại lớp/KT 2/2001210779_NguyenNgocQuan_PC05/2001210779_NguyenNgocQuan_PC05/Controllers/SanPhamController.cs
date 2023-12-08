using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2001210779_NguyenNgocQuan_PC05.Models;
namespace _2001210779_NguyenNgocQuan_PC05.Controllers
{
    public class SanPhamController : Controller
    {
        ShopDTDDDataContext db = new ShopDTDDDataContext();

        // GET: SanPham
        public ActionResult SanPhamPartial()
        {
            return View(db.SanPhams.OrderBy(s => s.TenSP).ToList());
        }

        public ActionResult SPTheoLoai(int? maLoai)
        {
            var sp = db.SanPhams.Where(s => s.MaLoai == maLoai).ToList();
            int? sl = db.SanPhams.Count(s => s.MaLoai == maLoai);
            if (sl == null)
            {
                ViewBag.TB = "Không có sản phẩm nào thuộc loại này!";
            }
            else
            {
                ViewBag.TB = null;
            }
            return View(sp);
        }

        [HttpPost]
        public ActionResult SearchSP(string txt_Search)
        {
            return View(db.SanPhams.Where(i => i.TenSP.Contains(txt_Search)).ToList());
        }


        public ActionResult XemChiTiet(int? msp)
        {
            SanPham sp = db.SanPhams.Single(s => s.MaSP == msp);
            if (msp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
    }
}