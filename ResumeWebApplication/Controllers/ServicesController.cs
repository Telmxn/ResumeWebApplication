using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebApplication.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public ServicesController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Services
        public PartialViewResult AllServices()
        {
            var services = _resumeDbContext.Services.ToList();
            return PartialView(services);
        }
    }
}