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
    public class ProjectsController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public ProjectsController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Projects
        public async Task<ActionResult> AllProjectsAsync()
        {
            var projects = await _resumeDbContext.Projects.ToListAsync();
            return View(projects);
        }
    }
}