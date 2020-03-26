namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class someChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resumes", "WorkPlace", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resumes", "WorkPlace", c => c.Int(nullable: false));
        }
    }
}
