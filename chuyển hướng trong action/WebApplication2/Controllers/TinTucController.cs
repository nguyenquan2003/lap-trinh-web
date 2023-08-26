using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult DanhSachTinTuc()
        {
            return View();
        }
        public ActionResult NoiDungTinTuc()
        {
            return View();
        }
    }
}