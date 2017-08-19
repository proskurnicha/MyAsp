namespace MyAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        GenreId = c.Byte(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        DateRelease = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            Sql(@"  INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy'),(2, 'Romance'), 
                    (3, 'Thriller'), (4, 'Family'), (5, 'Action'), (6, 'Cartoon')");
            Sql(@"  INSERT INTO Movies (ID, Name, GenreId, DateAdded, DateRelease, NumberInStock) 
                    VALUES
                    (1, 'Shreck', 6, '2015/5/4', '2011/01/12', 5),
                    (2, 'Game of Thrones', 3, '2015/5/4', '2011/01/12', 6),
                    (3, 'Gone With the Wind', 2, '2014/5/4', '2013/01/12', 5),
                    (4, 'Life', 4, '2017/5/4', '2012/01/12', 55)");

        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}
