using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenNgocBao_2001215617.Models;
namespace NguyenNgocBao_2001215617.Controllers
{
    public class ChuDeController : Controller
    {
        //
        dbQuanLyBanSachDataContext db = new dbQuanLyBanSachDataContext();
        // GET: /ChuDe/
        public ActionResult ChuDePartial()
        {
            var ListCD = db.ChuDes.Take(7).OrderBy(cd => cd.TenChuDe).ToList();
            return View(ListCD);
        }

        public ActionResult SachTheoCD(int MaCD)
        {
            MaCD = int.Parse(Request.QueryString["id"]);
            var ListSach = db.Saches.Where(s => s.MaChuDe == MaCD).OrderBy(s => s.GiaBan).ToList();
            if(ListSach.Count==0)
            {
                ViewBag.Sach = "Khong co sach nao thuoc chu de nay !";
            }
            return View(ListSach);
        }
	}
}