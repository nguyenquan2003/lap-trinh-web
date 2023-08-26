using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TrangChu()
        {
            //1. chuyen huong qua action khac, cung cotroller
            //return RedirectToAction("DangNhap");

            //2. chuyen huong khac cotroller
            //return RedirectToAction("DanhSachTinTuc","TinTuc");

            //3. chuyen huong toi 1 link
            //return Redirect("https://www.facebook.com/");

            //4. chuyen huong bang RouterName
            //return RedirectToRoute("Default");

            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
    }
}