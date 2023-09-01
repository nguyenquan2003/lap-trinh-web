using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenNgocQuan_2001210779.Models;

namespace NguyenNgocQuan_2001210779.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index
            (string txt_FullName, string txt_ID, string txt_Email, string file_image,
            string t_Note, string ck1, string ck2, string ck3, string otp_radio, string sc)
        {
            Infomation info = new Infomation()
            {
                FullName = txt_FullName,
                IdStudent = txt_ID,
                Email = txt_Email,
                FileImage = file_image,
                Note = t_Note,
                Check1 = !string.IsNullOrEmpty(ck1), 
                Check2 = !string.IsNullOrEmpty(ck2), 
                Check3 = !string.IsNullOrEmpty(ck3), 
                ChooseWorkTime = otp_radio,
                SelectCourse = sc
            };

            Session["info"] = info;

            return RedirectToAction("Info");
        }

        public ActionResult Info()
        {
            Infomation info = (Infomation)Session["info"];
            return View(info);
        }
        public ActionResult MaXacNhan()
        {
            return View();
        }
    }
}
