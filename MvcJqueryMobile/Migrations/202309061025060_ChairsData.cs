namespace MvcJqueryMobile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChairsData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        Category = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Heroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageId = c.String(),
                        Header = c.String(),
                        Footer = c.String(),
                        Introduction = c.String(),
                        ImageUrl = c.String(),
                        ImageAlt = c.String(),
                        VideoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Heroes");
            DropTable("dbo.Chairs");
            DropTable("dbo.Cars");
        }
    }
}
