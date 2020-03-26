﻿using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public HomeController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            var author = _resumeDbContext.Authors.Where(x => x.Id == 1).FirstOrDefault();
            return View(author);
        }
    }
}