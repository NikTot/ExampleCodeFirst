namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleCommonTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ArticleFirstTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ArticleFirstTypeProperty = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleCommonTables", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ArticleSecondTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ArticleFirstTypeProperty = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleCommonTables", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleSecondTypeTables", "Id", "dbo.ArticleCommonTables");
            DropForeignKey("dbo.ArticleFirstTypeTables", "Id", "dbo.ArticleCommonTables");
            DropIndex("dbo.ArticleSecondTypeTables", new[] { "Id" });
            DropIndex("dbo.ArticleFirstTypeTables", new[] { "Id" });
            DropTable("dbo.ArticleSecondTypeTables");
            DropTable("dbo.ArticleFirstTypeTables");
            DropTable("dbo.ArticleCommonTables");
        }
    }
}
