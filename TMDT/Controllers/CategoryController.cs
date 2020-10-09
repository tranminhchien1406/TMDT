﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string Category)
        {
            var db = new TMDT.Models.TMDTEntities();
            var ListNews = db.News.Where(c => c.Category.Alias == Category);
            return View(ListNews);
        }
    }
}