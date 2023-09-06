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
        public ActionResult Index()
        {
            //cách 1:
            //List<MayTinh> dsMay = MayTinh.KhoiTao5May(); // Gọi phương thức tĩnh KhoiTao5May() từ lớp MayTinh
            //return View(dsMay); // Truyền danh sách máy tính vào View

            //cách 2:
            return View(MayTinh.KhoiTao5May());
        }

        public ActionResult GiaThapNhat()
        {
            var DSGiaThap = MayTinh.KhoiTao5May().OrderBy(m => m.GiaBan).Take(2).ToList(); // Sắp xếp và lấy 2 máy tính có giá thấp nhất
            return View(DSGiaThap);
        }

        public ActionResult SapXepGiamDan()
        {
            var DSGiamDan = MayTinh.KhoiTao5May().OrderBy(m => m.GiaBan).ToList(); // Sắp xếp và lấy 2 máy tính có giá thấp nhất
            return View(DSGiamDan);
        }

        public ActionResult HangAsus()
        {
            var DSAsus = MayTinh.KhoiTao5May().Where(m => m.HangSanXuat=="Asus").ToList(); // Sắp xếp và lấy 2 máy tính có giá thấp nhất
            return View(DSAsus);
        }
    }
}
