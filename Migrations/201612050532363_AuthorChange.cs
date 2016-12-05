namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        RentalID = c.Int(nullable: false, identity: true),
                        RentalType = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RentalID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstNames = c.String(),
                        LastName = c.String(),
                        Biography = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PublishedYear = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ISBN)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        PublishedYear = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Copies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropForeignKey("dbo.Rentals", "AccountID", "dbo.Accounts");
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropIndex("dbo.Rentals", new[] { "AccountID" });
            DropTable("dbo.Media");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
            DropTable("dbo.Rentals");
            DropTable("dbo.Accounts");
        }
    }
}
