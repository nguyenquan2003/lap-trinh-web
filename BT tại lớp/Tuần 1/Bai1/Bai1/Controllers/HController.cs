using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class HController : Controller
    {
        // GET: H
        public ActionResult Index()
        {
            if(Session["UserName"]==null)
            {
                return RedirectToAction("DangNhap", "DN");
            }
            return View();
        }
    }
}