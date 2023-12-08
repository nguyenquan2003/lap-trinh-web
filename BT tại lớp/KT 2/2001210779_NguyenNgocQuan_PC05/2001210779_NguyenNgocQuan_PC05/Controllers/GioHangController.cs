using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2001210779_NguyenNgocQuan_PC05.Models;
namespace _2001210779_NguyenNgocQuan_PC05.Controllers
{
    public class GioHangController : Controller
    {
        ShopDTDDDataContext db = new ShopDTDDDataContext();
        private int TongSoLuong()
        {
            int totalSoLuong = 0;
            List<GioHang> firstGioHang = Session["GioHang"] as List<GioHang>;

            if (firstGioHang != null)
            {
                totalSoLuong = firstGioHang.Sum(sp => sp.sl);
            }

            return totalSoLuong;
        }
        private decimal TongThanhTien()
        {
            decimal totalThanhTien = 0;
            List<GioHang> firstGioHang = Session["GioHang"] as List<GioHang>;

            if (firstGioHang != null)
            {
                totalThanhTien = firstGioHang.Sum(sp => sp.thanhtien);
            }

            return totalThanhTien;
        }
        // GET: GioHang
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                Session["GioHang"] = new List<GioHang>();
            }

            List<GioHang> lst = Session["GioHang"] as List<GioHang>;
            return View(lst);
        }

        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            return PartialView();
        }
        public void Muasp(int msp)
        {
            if (Session["GioHang"] == null)
            {
                Session["GioHang"] = new List<GioHang>();
            }
            List<GioHang> lst = Session["GioHang"] as List<GioHang>;
            bool flag = true;
            if (lst.Count > 0)
            {
                foreach (var item in lst)
                {
                    if (item.masp == msp)
                    {
                        item.sl++;
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                GioHang cart = new GioHang();
                SanPham sp = db.SanPhams.FirstOrDefault(i => i.MaSP == msp);
                cart.masp = sp.MaSP;
                cart.ten = sp.TenSP;
                cart.anh = sp.Anh;
                cart.sl = 1;
                cart.thanhtien = (sp.GiaBan ?? 0) * cart.sl;
                cart.dongia = (sp.GiaBan ?? 0);
                lst.Add(cart);
            }

            Session["GioHang"] = lst;

        }
        public ActionResult muaOLaiPage(int msp)
        {
            Muasp(msp);
            int masptemp = msp;
            return RedirectToAction("XemChiTiet", "SanPham", new { msp = masptemp });
        }
        public ActionResult MuaspOpage(int msp)
        {
            Muasp(msp);
            return RedirectToAction("GioHang");
        }
        public ActionResult ThemVaoGioHang(int msp)
        {
            Muasp(msp);
            return RedirectToAction("GioHang");
        }

        public ActionResult XoaKhoiGioHang(int msp)
        {
            List<GioHang> lst = Session["GioHang"] as List<GioHang>;
            if (lst != null)
            {
                var itemToRemove = lst.FirstOrDefault(item => item.masp == msp);
                if (itemToRemove != null)
                {
                    lst.Remove(itemToRemove);
                }
            }
            Session["GioHang"] = lst;
            return RedirectToAction("GioHang");
        }

        public ActionResult CapNhatGioHang(int msp, int sl)
        {
            List<GioHang> lst = Session["GioHang"] as List<GioHang>;
            if (lst != null)
            {
                var itemToUpdate = lst.FirstOrDefault(item => item.masp == msp);
                if (itemToUpdate != null)
                {
                    itemToUpdate.sl = sl;
                    itemToUpdate.thanhtien = itemToUpdate.dongia * sl;
                }
            }
            Session["GioHang"] = lst;
            return RedirectToAction("GioHang");
        }

        public ActionResult LamMoiGioHang()
        {
            Session["GioHang"] = new List<GioHang>();
            return RedirectToAction("GioHang");
        }
    }
}