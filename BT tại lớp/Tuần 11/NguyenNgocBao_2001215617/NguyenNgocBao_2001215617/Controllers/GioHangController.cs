using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenNgocBao_2001215617.Models;
namespace NguyenNgocBao_2001215617.Controllers
{
    public class GioHangController : Controller
    {
        //
        // GET: /GioHang/
        public ActionResult GioHang()
        {
            if(Session["GioHang"]==null)
            {
                return RedirectToAction("Index1", "Home");
            }
            List<GioHang> lstGioHang = LayGioHang();

            ViewBag.To
            return View();
        }
	}
}