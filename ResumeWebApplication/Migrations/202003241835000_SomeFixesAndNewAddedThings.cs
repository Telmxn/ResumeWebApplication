namespace ResumeWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeFixesAndNewAddedThings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Skills", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Services", new[] { "Author_Id" });
            DropIndex("dbo.Skills", new[] { "Author_Id" });
            RenameColumn(table: "dbo.Services", name: "Author_Id", newName: "AuthorId");
            RenameColumn(table: "dbo.Skills", name: "Author_Id", newName: "AuthorId");
            AlterColumn("dbo.Services", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Skills", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Services", "AuthorId");
            CreateIndex("dbo.Skills", "AuthorId");
            AddForeignKey("dbo.Services", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Skills", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
            DropColumn("dbo.Services", "AuhtorId");
            DropColumn("dbo.Skills", "AuhtorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Skills", "AuhtorId", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "AuhtorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Skills", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Services", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Skills", new[] { "AuthorId" });
            DropIndex("dbo.Services", new[] { "AuthorId" });
            AlterColumn("dbo.Skills", "AuthorId", c => c.Int());
            AlterColumn("dbo.Services", "AuthorId", c => c.Int());
            RenameColumn(table: "dbo.Skills", name: "AuthorId", newName: "Author_Id");
            RenameColumn(table: "dbo.Services", name: "AuthorId", newName: "Author_Id");
            CreateIndex("dbo.Skills", "Author_Id");
            CreateIndex("dbo.Services", "Author_Id");
            AddForeignKey("dbo.Skills", "Author_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.Services", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
