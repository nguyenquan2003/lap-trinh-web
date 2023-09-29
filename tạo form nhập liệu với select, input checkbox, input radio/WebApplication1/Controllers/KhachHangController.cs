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
        public ActionResult ThemMoi(KhachHang model)
        {
            if(model.ID == 0)
            {
                ModelState.AddModelError("", "ID phải nhập > 0");
                return View(model);
            }
            DanhSachKhachHang.dsKhachHang.Add(model);
            return RedirectToAction("DanhSach");
        }
    }
}