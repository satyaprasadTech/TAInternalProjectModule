﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TAClassifiedApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Home()
        {
            return View();
        }

        // GET: Contactus
        public ActionResult Contactus()
        {
            return View();
        }

        // GET: Postad
        public ActionResult Postad()
        {
            return View();
        }

        // GET: ViewDetail
        public ActionResult ViewDetail()
        {
            return View();
        }
    }
}