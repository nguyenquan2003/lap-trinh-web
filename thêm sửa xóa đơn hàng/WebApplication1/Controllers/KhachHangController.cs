using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        public ActionResult DanhSach()
        {
            return View(DanhSachKhachHang.dsKhachHang);
        }
        public ActionResult ThemMoi()
        {
            return View(new KhachHang() { ID = 0 });
        }
        [HttpPost]
        public ActionResult ThemMoi(KhachHang model, HttpPostedFileBase fileAnh)
        {
            if (model.ID == 0)
            {
                ModelState.AddModelError("", "ID phải nhập > 0");
                return View(model);
            }
            if (fileAnh.ContentLength > 0)
            {
                // Luu file
                string rootFolder = Server.MapPath("/Data/");
                string pathImg = rootFolder + fileAnh.FileName;
                fileAnh.SaveAs(pathImg);

                // Lưu thuộc tính url Hinh Anh
                model.UrlHinhAnh = "/Data/" + fileAnh.FileName;
            }
            DanhSachKhachHang.dsKhachHang.Add(model);
            return RedirectToAction("DanhSach");
        }

        public ActionResult CapNhat(int? idKhachHang)
        {
            //tìm ra khách hàng cần sửa
            var KhachHang = DanhSachKhachHang.dsKhachHang.SingleOrDefault(m => m.ID == idKhachHang);
            //truyền thông tin đối tượng cần sửa bên view
            return View(KhachHang);
        }

        [HttpPost]
        public ActionResult CapNhat(KhachHang model)
        {
            // KT điều kiện nếu TenKhachHang là rỗng hoặc null
            if (string.IsNullOrEmpty(model.TenKhachHang))
            {
                ModelState.AddModelError("", "Bạn chưa nhập tên khách hàng");
                return View(model);
            }
            // Tìm ra đối tượng cần sửa
            var khachHang = DanhSachKhachHang.dsKhachHang.SingleOrDefault(m => m.ID == model.ID);
            //if (khachHang == null)
            //{
            //    // Xử lý trường hợp không tìm thấy khachHang, có thể trả về HttpNotFoundResult
            //    return HttpNotFound();
            //}
            // Cập nhật dữ liệu mới cho đối tượng cần sửa
            khachHang.TenKhachHang = model.TenKhachHang;
            khachHang.DiaChiNhanHang = model.DiaChiNhanHang;
            khachHang.Email = model.Email;
            khachHang.GioiTinh = model.GioiTinh;
            khachHang.SoDienThoai = model.SoDienThoai;
            khachHang.UrlHinhAnh = model.UrlHinhAnh;
            return RedirectToAction("DanhSach");
        }

        public ActionResult Xoa(int idKhachHang)
        {
            // tìm ra đối tượng khách hàng cần sửa
            var khacHang = DanhSachKhachHang.dsKhachHang.SingleOrDefault(m => m.ID == idKhachHang);
            // Thực hiện xóa
            DanhSachKhachHang.dsKhachHang.Remove(khacHang);
            // Quay lại trang danh sách
            return RedirectToAction("DanhSach");
        }
    }
}