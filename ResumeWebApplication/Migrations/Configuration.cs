namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ResumeWebApplication.Data.ResumeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ResumeWebApplication.Data.ResumeDbContext context)
        {
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
