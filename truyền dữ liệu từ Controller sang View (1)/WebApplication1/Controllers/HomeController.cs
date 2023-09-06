using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//thêm dg dẫn class vào
using WebApplication1.Math;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //class Math
            //cách 1: truyền bằng Viewbag
            //ViewBag.A = new tinh_toan().sum(1, 2);

            //int a = 10;
            //ViewBag.A = a;

            //cách 2: truyền qua tham số của hàm View
            //return View(10); vd 1 con số chẳng hạn

            ////cách 1:
            //var SV = new SinhVien();
            //SV.ID = 1;
            //SV.MaSo = "sv001";
            //SV.HoTen = "Nguyen Van A";
            //SV.Lop = "lớp 12";

            //cách 2: tạo list
            List<SinhVien> DSSV = new List<SinhVien>();
            var SV1 = new SinhVien();
            SV1.ID = 1;
            SV1.MaSo = "sv001";
            SV1.HoTen = "Nguyen Van A";
            SV1.Lop = "lớp 12";
            ViewBag.SV = SV1;
            DSSV.Add(SV1);

            
            var SV2 = new SinhVien();
            SV2.ID = 2;
            SV2.MaSo = "sv002";
            SV2.HoTen = "Nguyen Van B";
            SV2.Lop = "lớp 11";
            ViewBag.SV = SV2;
            DSSV.Add(SV2);

            return View(DSSV);
        }
    }
}