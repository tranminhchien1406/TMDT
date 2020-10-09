﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dbContext = new TMDT.Models.TMDTEntities();
            var model = dbContext.Categories;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}