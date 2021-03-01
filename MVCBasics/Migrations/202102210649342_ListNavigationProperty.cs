namespace MVCBasics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListNavigationProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cart", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.MenuItems", "Cart_InvoiceId", c => c.Int());
            CreateIndex("dbo.MenuItems", "Cart_InvoiceId");
            AddForeignKey("dbo.MenuItems", "Cart_InvoiceId", "dbo.Cart", "InvoiceId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "Cart_InvoiceId", "dbo.Cart");
            DropIndex("dbo.MenuItems", new[] { "Cart_InvoiceId" });
            DropColumn("dbo.MenuItems", "Cart_InvoiceId");
            DropColumn("dbo.Cart", "UserId");
        }
    }
}
