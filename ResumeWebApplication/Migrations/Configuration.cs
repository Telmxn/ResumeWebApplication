namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ResumeWebApplication.Data.ResumeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ResumeWebApplication.Data.ResumeDbContext context)
        {
            context.Resumes.AddOrUpdate(new Data.Resume
            {
                Id = 1,
                WorkName = "Web Designer",
                AuthorId = 1,
                StartDate = DateTime.ParseExact("17.01.2019","dd.MM.yyyy",CultureInfo.InvariantCulture),
                EndDate = DateTime.Now,
                WorkPlace = "Fiverr",
                About = "I worked as a Web Programmer at Fiverr for over 1 year. I am very pleased with my work there and my clients."
            });
            context.Services.AddOrUpdate(new Data.Service
            {
                AuthorId = 1,
                Id = 1,
                Name = "Web Design",
                LogoPath = "development.png"
            }, new Data.Service
            {
                AuthorId = 1,
                Id = 2,
                Name = "App Developing",
                LogoPath = "development.png"
            }, new Data.Service
            {
                AuthorId = 1,
                Id = 3,
                Name = "Web Developer",
                LogoPath = "development.png"
            });
            context.Skills.AddOrUpdate(new Data.Skill
            {
                Id = 1,
                AuthorId = 1,
                Name = "HTML5",
                Percent = 90
            }, new Data.Skill
            {
                Id = 2,
                AuthorId = 1,
                Name = "CSS3",
                Percent = 92
            }, new Data.Skill
            {
                Id = 3,
                AuthorId = 1,
                Name = "JS",
                Percent = 85
            }, new Data.Skill
            {
                Id = 4,
                AuthorId = 1,
                Name = "C#",
                Percent = 75
            }, new Data.Skill
            {
                Id = 5,
                AuthorId = 1,
                Name = "Asp.NET",
                Percent = 60
            }, new Data.Skill
            {
                Id = 6,
                AuthorId = 1,
                Name = "Photoshop",
                Percent = 70
            });
            context.Projects.AddOrUpdate(new Data.Project
            {
                AuhtorId = 1,
                Category = "Web Design",
                Id = 1,
                ImagePath = "booksite.png",
                Name = "Site about Book"
            }, new Data.Project
            {
                AuhtorId = 1,
                Category = "Web Design",
                Id = 2,
                ImagePath = "bolgezysitedesign.png",
                Name = "Blogezy Site Design"
            }, new Data.Project
            {
                AuhtorId = 1,
                Category = "Web Design",
                Id = 3,
                ImagePath = "onetechsitedesign.png",
                Name = "One Tech Site Design"
            }, new Data.Project
            {
                AuhtorId = 1,
                Category = "Web Design Fix",
                Id = 4,
                ImagePath = "siteproblemfix.png",
                Name = "Site Problem Fix"
            }, new Data.Project
            {
                AuhtorId = 1,
                Category = "Web Design",
                Id = 5,
                ImagePath = "testyourselfsitedesign.png",
                Name = "Test Yourself Site Design"
            }, new Data.Project
            {
                AuhtorId = 1,
                Category = "Software Development",
                Id = 6,
                ImagePath = "signupdesignforpc.png",
                Name = "Sign Up Win Form Application"
            });
            context.Authors.AddOrUpdate(new Data.Author
            {
                About = "Hello, I am Telman. I am a Web Programmer. I have done this site for giving information to you about me.",
                Address = "Baku, Ganja ave. 80/81",
                AwardsAmount = 2,
                BirthDate = DateTime.ParseExact("March 22,2004","MMMM dd,yyyy", CultureInfo.InvariantCulture),
                Country = "Azerbaijan",
                CupsOfCoffee = 5,
                Email = "telmanyusifov78@gmail.com",
                HappyCustomers = 7,
                Id = 1,
                Name = "Telman",
                PhoneNumber = "+994-50-403-79-35",
                ProjectsComplete = 30,
                Surname = "Yusifov",
                Website = "cloneprogramming.net",
                Work = "A Freelance Web Programmer",
                ZipCode = "AZ1000"
            });
            context.Menus.AddOrUpdate(new Data.Menu
            {
                Id = 1,
                Name = "Home",
                IsActive = true,
                Order=1
            }, new Data.Menu
            {
                Id = 2,
                Name = "About",
                IsActive = true,
                Order = 2
            }, new Data.Menu
            {
                Id = 3,
                Name = "Resume",
                IsActive = true,
                Order = 3
            }, new Data.Menu
            {
                Id = 4,
                Name = "Services",
                IsActive = true,
                Order = 4
            }, new Data.Menu
            {
                Id = 5,
                Name = "Skills",
                IsActive = true,
                Order = 5
            }, new Data.Menu
            {
                Id = 6,
                Name = "Projects",
                IsActive = true,
                Order = 6
            }, new Data.Menu
            {
                Id = 7,
                Name = "Contact",
                IsActive = true,
                Order = 7
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
