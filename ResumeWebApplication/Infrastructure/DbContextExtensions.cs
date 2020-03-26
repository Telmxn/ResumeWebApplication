using ResumeWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Infrastructure
{
    public static class DbContextExtensions
    {
        public static IEnumerable<Resume> Getxbyx(this ResumeDbContext resumeDbContext,int row,int itemperRow)
        {
            return resumeDbContext.Resumes
                .OrderBy(x => x.StartDate).Skip((row - 1) * itemperRow).Take(itemperRow).Select(x => new Resume
                {
                    Id = x.Id,
                    About = x.About,
                    AuthorId = x.AuthorId,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    WorkName = x.WorkName,
                    WorkPlace = x.WorkPlace
                }).ToList();
        }
    }
}