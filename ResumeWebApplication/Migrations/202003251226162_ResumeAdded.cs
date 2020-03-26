namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResumeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkName = c.String(),
                        StartDate = c.Int(nullable: false),
                        EndDate = c.Int(nullable: false),
                        WorkPlace = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        About = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Resumes", new[] { "AuthorId" });
            DropTable("dbo.Resumes");
        }
    }
}
