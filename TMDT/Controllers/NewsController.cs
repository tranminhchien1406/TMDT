﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index(string Category, string Alias)
        {
            var db = new TMDT.Models.TMDTEntities();
            var ListNews = db.News.Where(c => c.Category.Alias == Category && c.Category.Alias == Alias);
            return View(ListNews);
        }
    }
}