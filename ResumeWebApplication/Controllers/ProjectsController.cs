using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult AllProjects()
        {
            var projects = _resumeDbContext.Projects.ToList();
            return View(projects);
        }
    }
}