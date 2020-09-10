namespace CodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        RatingId = c.Int(nullable: false),
                        ProductionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Productions", t => t.ProductionId, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.RatingId, cascadeDelete: true) 
                .Index(t => t.RatingId)
                .Index(t => t.ProductionId); 
            
            CreateTable(
                "dbo.Productions",
                c => new
                    {
                        ProductionId = c.Int(nullable: false, identity: true),
                        ProductionName = c.String(),
                    })
                .PrimaryKey(t => t.ProductionId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingId = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RatingId);
            
            CreateTable(
                "dbo.MovieGenders",
                c => new
                    {
                        Movie_MovieId = c.Int(nullable: false),
                        Gender_GenderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieId, t.Gender_GenderId })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.Gender_GenderId, cascadeDelete: true)
                .Index(t => t.Movie_MovieId)
                .Index(t => t.Gender_GenderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "RatingId", "dbo.Ratings");
            DropForeignKey("dbo.Movies", "ProductionId", "dbo.Productions");
            DropForeignKey("dbo.MovieGenders", "Gender_GenderId", "dbo.Genders");
            DropForeignKey("dbo.MovieGenders", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.MovieGenders", new[] { "Gender_GenderId" });
            DropIndex("dbo.MovieGenders", new[] { "Movie_MovieId" });
            DropIndex("dbo.Movies", new[] { "ProductionId" });
            DropIndex("dbo.Movies", new[] { "RatingId" });
            DropTable("dbo.MovieGenders");
            DropTable("dbo.Ratings");
            DropTable("dbo.Productions");
            DropTable("dbo.Movies");
            DropTable("dbo.Genders");
        }
    }
}
