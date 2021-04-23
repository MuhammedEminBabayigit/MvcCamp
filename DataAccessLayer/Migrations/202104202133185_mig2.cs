namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "TagID", "dbo.Tags");
            DropIndex("dbo.Posts", new[] { "TagID" });
            AddColumn("dbo.Tags", "PostID", c => c.Int());
            CreateIndex("dbo.Tags", "PostID");
            AddForeignKey("dbo.Tags", "PostID", "dbo.Posts", "PostID");
            DropColumn("dbo.Posts", "TagID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "TagID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tags", "PostID", "dbo.Posts");
            DropIndex("dbo.Tags", new[] { "PostID" });
            DropColumn("dbo.Tags", "PostID");
            CreateIndex("dbo.Posts", "TagID");
            AddForeignKey("dbo.Posts", "TagID", "dbo.Tags", "TagID", cascadeDelete: true);
        }
    }
}
