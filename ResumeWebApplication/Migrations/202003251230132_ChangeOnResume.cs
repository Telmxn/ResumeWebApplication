namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOnResume : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resumes", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Resumes", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resumes", "EndDate", c => c.Int(nullable: false));
            AlterColumn("dbo.Resumes", "StartDate", c => c.Int(nullable: false));
        }
    }
}
