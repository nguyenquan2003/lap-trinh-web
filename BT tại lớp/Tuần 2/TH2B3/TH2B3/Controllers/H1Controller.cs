using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH2B3.Models;
namespace TH2B3.Controllers
{
    public class H1Controller : Controller
    {
        // GET: H1
        public ActionResult Index1()
        {
            var empl = new NhanVien();
            ViewData["empl"] = empl;
            return View();
        }
    }
}