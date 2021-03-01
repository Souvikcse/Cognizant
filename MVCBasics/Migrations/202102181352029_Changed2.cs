namespace MVCBasics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cart", "MenuItemId");
            AddForeignKey("dbo.Cart", "MenuItemId", "dbo.MenuItems", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cart", "MenuItemId", "dbo.MenuItems");
            DropIndex("dbo.Cart", new[] { "MenuItemId" });
        }
    }
}
