namespace TravelTrip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_comments_update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Blog_ID", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "Blog_ID" });
            RenameColumn(table: "dbo.Comments", name: "Blog_ID", newName: "Blogid");
            AlterColumn("dbo.Comments", "Blogid", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "Blogid");
            AddForeignKey("dbo.Comments", "Blogid", "dbo.Blogs", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Blogid", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "Blogid" });
            AlterColumn("dbo.Comments", "Blogid", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "Blogid", newName: "Blog_ID");
            CreateIndex("dbo.Comments", "Blog_ID");
            AddForeignKey("dbo.Comments", "Blog_ID", "dbo.Blogs", "ID");
        }
    }
}
