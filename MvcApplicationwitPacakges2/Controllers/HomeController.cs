﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsvHelper;

namespace MvcApplicationwitPacakges2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "csvhelper type: " + typeof(CsvHelper.CsvReader).AssemblyQualifiedName;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
