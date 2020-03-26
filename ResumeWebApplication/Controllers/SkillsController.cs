using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebApplication.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public SkillsController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Skills
        public PartialViewResult AllSkills()
        {
            var skills = _resumeDbContext.Skills.ToList();
            return PartialView(skills);
        }
    }
}