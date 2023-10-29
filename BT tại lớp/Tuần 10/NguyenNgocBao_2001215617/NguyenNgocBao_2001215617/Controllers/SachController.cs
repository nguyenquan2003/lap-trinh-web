using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenNgocBao_2001215617.Models;
namespace NguyenNgocBao_2001215617.Controllers
{
    public class SachController : Controller
    {
        //
        dbQuanLyBanSachDataContext db = new dbQuanLyBanSachDataContext();
        // GET: /Sach/
        public ActionResult SachPartial()
        {
            var ListCD = db.Saches.ToList();
            return View(ListCD);
        }
	}
}