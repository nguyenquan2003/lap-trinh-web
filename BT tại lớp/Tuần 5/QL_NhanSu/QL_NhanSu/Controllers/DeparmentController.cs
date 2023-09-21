using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_NhanSu.Models;

namespace QL_NhanSu.Controllers
{
    public class DeparmentController : Controller
    {
        //
        // GET: /Deparment/
        public ActionResult ShowDeparment()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> ListDept = obj.getData();
            return View(ListDept);
        }
        public ActionResult ShowDetailsDept(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            ViewData["sl"] = obj.SoNV(id);
            return View(dept);
        }
        public ActionResult ShowDDLDept()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> deptlist = obj.getData();
            return View(deptlist);
        }
        public ActionResult ShowListEmplByDept(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            List<Employee> listEmp = obj.ListEmplByDept(id);
            ViewBag.empList = listEmp;
            return View(dept);
        }
	}
}