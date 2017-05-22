namespace VidlyThirdTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GenreTs", newName: "Genres");
            RenameColumn(table: "dbo.Movies", name: "GenreTId", newName: "GenreId");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreTId", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_GenreTId");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "GenreTId");
            RenameTable(name: "dbo.Genres", newName: "GenreTs");
        }
    }
}
