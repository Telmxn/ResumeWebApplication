using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebApplication.Controllers
{
    public class MenusController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public MenusController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Menus
        public PartialViewResult AllMenus()
        {
            var menus = _resumeDbContext.Menus.Where(x=>x.IsActive==true).ToList();
            return PartialView(menus);
        }
    }
}