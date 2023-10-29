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

        public ActionResult SearchSach(string txt_Search)
        {
            var ListBook = db.Saches.Where(s => s.TenSach.Contains(txt_Search)).ToList();
            if (ListBook.Count == 0)
            {
                ViewBag.TB = "Khong tim thay";
            }
            return View(ListBook);
        }

        public ActionResult XemChiTietSach(int ms)
        {
            Sach sach = db.Saches.Single(s => s.MaSach == ms);
            if(sach==null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }
        public ActionResult SachTheoCD(int MaCD)
        {

            var ListSach = db.Saches.Where(s => s.MaChuDe == MaCD).OrderBy(s => s.GiaBan).ToList();
            if (ListSach.Count == 0)
            {
                ViewBag.Sach = "Khong co sach nao thuoc chu de nay !";
            }
            return View(ListSach);
        }

	}
}