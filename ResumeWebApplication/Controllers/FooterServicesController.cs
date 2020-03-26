using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebApplication.Controllers
{
    public class FooterServicesController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public FooterServicesController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: FooterServices
        public PartialViewResult AllFooterServices()
        {
            var footerServices = _resumeDbContext.Services.ToList();
            return PartialView(footerServices);
        }
    }
}