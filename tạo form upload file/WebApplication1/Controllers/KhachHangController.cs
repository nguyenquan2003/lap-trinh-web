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
            return View(new KhachHang(){ ID=0 });
        }
        [HttpPost]
        public ActionResult ThemMoi(KhachHang model, HttpPostedFileBase fileAnh)
        {
            if(model.ID == 0)
            {
                ModelState.AddModelError("", "ID phải nhập > 0");
                return View(model);
            }
            if (fileAnh.ContentLength > 0)
            {
                // Luu file
                string rootFolder = Server.MapPath("/Data/");
                string pathImg = rootFolder+fileAnh.FileName;
                fileAnh.SaveAs(pathImg);

                // Lưu thuộc tính url Hinh Anh
                model.UrlHinhAnh = "/Data/" + fileAnh.FileName;
            }
            DanhSachKhachHang.dsKhachHang.Add(model);
            return RedirectToAction("DanhSach");
        }
    }
}