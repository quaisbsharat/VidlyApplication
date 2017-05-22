namespace VidlyThirdTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreTs",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenreTId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreTId");
            AddForeignKey("dbo.Movies", "GenreTId", "dbo.GenreTs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTId", "dbo.GenreTs");
            DropIndex("dbo.Movies", new[] { "GenreTId" });
            DropColumn("dbo.Movies", "GenreTId");
            DropTable("dbo.GenreTs");
        }
    }
}
