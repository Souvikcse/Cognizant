namespace MVCBasics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListNavigationPropertyupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cart", "MenuItemId", "dbo.MenuItems");
            DropForeignKey("dbo.MenuItems", "Cart_InvoiceId", "dbo.Cart");
            DropIndex("dbo.Cart", new[] { "MenuItemId" });
            RenameColumn(table: "dbo.MenuItems", name: "Cart_InvoiceId", newName: "Cart_UserId");
            RenameIndex(table: "dbo.MenuItems", name: "IX_Cart_InvoiceId", newName: "IX_Cart_UserId");
            DropPrimaryKey("dbo.Cart");
            AlterColumn("dbo.Cart", "UserId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cart", "UserId");
            AddForeignKey("dbo.MenuItems", "Cart_UserId", "dbo.Cart", "UserId");
            DropColumn("dbo.Cart", "InvoiceId");
            DropColumn("dbo.Cart", "MenuItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cart", "MenuItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Cart", "InvoiceId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.MenuItems", "Cart_UserId", "dbo.Cart");
            DropPrimaryKey("dbo.Cart");
            AlterColumn("dbo.Cart", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Cart", "InvoiceId");
            RenameIndex(table: "dbo.MenuItems", name: "IX_Cart_UserId", newName: "IX_Cart_InvoiceId");
            RenameColumn(table: "dbo.MenuItems", name: "Cart_UserId", newName: "Cart_InvoiceId");
            CreateIndex("dbo.Cart", "MenuItemId");
            AddForeignKey("dbo.MenuItems", "Cart_InvoiceId", "dbo.Cart", "InvoiceId");
            AddForeignKey("dbo.Cart", "MenuItemId", "dbo.MenuItems", "Id", cascadeDelete: true);
        }
    }
}
