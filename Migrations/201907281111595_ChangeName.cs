namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArticleSecondTypeTables", "ArticleSecondTypeProperty", c => c.String());
            DropColumn("dbo.ArticleSecondTypeTables", "ArticleFirstTypeProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ArticleSecondTypeTables", "ArticleFirstTypeProperty", c => c.String());
            DropColumn("dbo.ArticleSecondTypeTables", "ArticleSecondTypeProperty");
        }
    }
}
