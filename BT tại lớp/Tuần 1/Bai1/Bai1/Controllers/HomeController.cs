using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public string Index1(string id , string name)
        {
            return "ID = " + id +  "Name = " + name;
        }

        public string Index2()
        {
            return "ID = " + Request.QueryString["id"] + "name=" + Request.QueryString["name"];
        }

        public ActionResult Index3()
        {
            ViewBag.id = Request.QueryString["id"];
            ViewData["name"]= Request.QueryString["name"];
            return View();
        }
    }
}