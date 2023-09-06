using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Thêm dòng dẫn class vào
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        /*cách 1:
        public ActionResult Index()
        {
            //đang thêm một đối tượng MayTinh vào danh sách listMayTinh trong lớp DanhSachMayTinh.
            //Sau đó, bạn lấy danh sách listMayTinh và truyền nó vào View để hiển thị trên trang chủ của ứng dụng web.
            DanhSachMayTinh.listMayTinh.Add(new MayTinh()
            {
                MaMay = "1234567890",
                DongMay = "Asus Nitro",
                GiaBan = 15000000,
                NgaySanXuat = new DateTime(2020, 3, 2),
                HangSanXuat = "Asus"
            });
            var ds5May = DanhSachMayTinh.listMayTinh;
            return View(ds5May); // Truyền danh sách máy tính vào View
        }
        */

        //cách 2:
        public ActionResult Index()
        {
            return View(DanhSachMayTinh.listMayTinh);
        }

        [HttpGet]
        public ActionResult ThemMayTinhMoi()
        {
            return View();
        }
        public ActionResult LuuThemMayTinhMoi(string Ma_May, string Dong_May,double Gia_Ban, DateTime Ngay_San_Xuat, string Hang_San_Xuat)
        {
            DanhSachMayTinh.listMayTinh.Add(new MayTinh() {
            MaMay = Ma_May,
            DongMay = Dong_May,
            GiaBan = Gia_Ban,
            NgaySanXuat = Ngay_San_Xuat,
            HangSanXuat= Hang_San_Xuat
            });
            return RedirectToAction("Index");
        }
    }
}
