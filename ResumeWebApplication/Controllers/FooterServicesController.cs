using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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
        [ActionName("AllFooterServices")]
        public async Task<PartialViewResult> AllFooterServicesAsync()
        {
            var footerServices = await _resumeDbContext.Services.ToListAsync();
            return PartialView(footerServices);
        }
    }
}