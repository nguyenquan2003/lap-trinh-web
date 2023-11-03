using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DonHangController : Controller
    {
        // GET: DonHang
        public ActionResult DanhSach()
        {
            return View(StaticDonHang.DanhSachDonHang);
        }
        public ActionResult ThemDonHang()
        {
            return View(new DonHang());
        }
        [HttpPost]
        public ActionResult ThemDonHang(DonHang model)
        {
            StaticDonHang.DanhSachDonHang.Add(model);
            return RedirectToAction("DanhSach");
        }

        public ActionResult CapNhatDonHang(int idDonHang)
        {
            var updateModel = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            return View(updateModel);
        }
        [HttpPost]
        public ActionResult CapNhatDonHang(DonHang model)
        {
            StaticDonHang.DanhSachDonHang.Add(model);
            var updateModel = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID==model.ID);
            updateModel.NgayDatHang = model.NgayDatHang;
            updateModel.SoDienThoai = model.SoDienThoai;
            updateModel.TenKhachHang = model.TenKhachHang;
            updateModel.DiaChiGiaoHang = model.DiaChiGiaoHang;
            return RedirectToAction("DanhSach");
        }
        public ActionResult XoaDonHang(int idDonHang)
        {
            var updateModel = StaticDonHang.DanhSachDonHang.SingleOrDefault(m => m.ID == idDonHang);
            StaticDonHang.DanhSachDonHang.Remove(updateModel);
            return RedirectToAction("DanhSach");
        }
    }
}