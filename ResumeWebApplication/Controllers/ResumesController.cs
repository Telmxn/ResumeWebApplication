using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWebApplication.Controllers
{
    public class ResumesController : Controller
    {
        private readonly ResumeDbContext _resumeDbContext;
        public ResumesController()
        {
            _resumeDbContext = new ResumeDbContext();
        }
        // GET: Resumes
        public PartialViewResult AllResumes()
        {
            var resumes = _resumeDbContext.Resumes.ToList();
            return PartialView(resumes);
        }
    }
}