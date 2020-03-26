using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Data
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext():base("myResumeDbConnection") { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}