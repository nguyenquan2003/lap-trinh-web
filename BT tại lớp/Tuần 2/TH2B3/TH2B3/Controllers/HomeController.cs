﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH2B3.Models;

namespace TH2B3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var empl = new Employee();
            ViewData["empl"] = empl;
            return View();
        }
    }
}