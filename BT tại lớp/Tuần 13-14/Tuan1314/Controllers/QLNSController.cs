using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan1314.Models;

namespace Tuan1314.Controllers
{
    public class QLNSController : Controller
    {
        //
        // GET: /QLNS/

        public ActionResult ShowDataEmpDept()
        {
            QLNS_ApiController qlns_api = new QLNS_ApiController();
            List<EmpDepMix> listEDM = qlns_api.GetEmpDeptLists();
            return View(listEDM);
        }
        public ActionResult ShowDetailEmpDept(int id)
        {
            QLNS_ApiController qlns_api = new QLNS_ApiController();
            EmpDepMix EDM = qlns_api.GetEmpDept(id);
            return View(EDM);
        }
	}
}