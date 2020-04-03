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
    public class HomeController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public HomeController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Home
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var author = await _resumeDbContext.Authors.Where(x => x.Id == 1).FirstOrDefaultAsync();
            return View(author);
        }
    }
}