namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        ProjectsComplete = c.Int(nullable: false),
                        CupsOfCoffee = c.Int(nullable: false),
                        AwardsAmount = c.Int(nullable: false),
                        HappyCustomers = c.Int(nullable: false),
                        Website = c.String(),
                        About = c.String(),
                        Work = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        ImagePath = c.String(),
                        AuhtorId = c.Int(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LogoPath = c.String(),
                        AuhtorId = c.Int(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Percent = c.Byte(nullable: false),
                        AuhtorId = c.Int(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Services", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Projects", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Skills", new[] { "Author_Id" });
            DropIndex("dbo.Services", new[] { "Author_Id" });
            DropIndex("dbo.Projects", new[] { "Author_Id" });
            DropTable("dbo.Menus");
            DropTable("dbo.Skills");
            DropTable("dbo.Services");
            DropTable("dbo.Projects");
            DropTable("dbo.Authors");
        }
    }
}
