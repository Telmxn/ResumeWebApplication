namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderAddedToMenuAndSomeChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Order", c => c.Byte(nullable: false));
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Authors", "Surname", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Authors", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Website", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "About", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Work", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "ImagePath", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Services", "LogoPath", c => c.String(nullable: false));
            AlterColumn("dbo.Skills", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Skills", "Name", c => c.String());
            AlterColumn("dbo.Services", "LogoPath", c => c.String());
            AlterColumn("dbo.Services", "Name", c => c.String());
            AlterColumn("dbo.Projects", "ImagePath", c => c.String());
            AlterColumn("dbo.Projects", "Category", c => c.String());
            AlterColumn("dbo.Projects", "Name", c => c.String());
            AlterColumn("dbo.Authors", "Work", c => c.String());
            AlterColumn("dbo.Authors", "About", c => c.String());
            AlterColumn("dbo.Authors", "Website", c => c.String());
            AlterColumn("dbo.Authors", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Authors", "Email", c => c.String());
            AlterColumn("dbo.Authors", "Country", c => c.String());
            AlterColumn("dbo.Authors", "ZipCode", c => c.String());
            AlterColumn("dbo.Authors", "Address", c => c.String());
            AlterColumn("dbo.Authors", "Surname", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
            DropColumn("dbo.Menus", "Order");
        }
    }
}
