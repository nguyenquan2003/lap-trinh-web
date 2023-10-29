using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenNgocBao_2001215617.Models;
namespace NguyenNgocBao_2001215617.Controllers
{
    public class NhaXuatBanController : Controller
    {
        //
        dbQuanLyBanSachDataContext db = new dbQuanLyBanSachDataContext();
        // GET: /NhaXuatBan/
        public ActionResult NhaXuatBanPartial()
        {
            var ListCD = db.NhaXuatBans.Take(7).OrderBy(cd => cd.TenNXB).ToList();
            return View(ListCD);
            
        }
	}
}