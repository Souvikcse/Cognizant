namespace MVCBasics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListNavigationPropertyupdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MenuItems", "Cart_UserId", "dbo.Cart");
            RenameColumn(table: "dbo.MenuItems", name: "Cart_UserId", newName: "Cart_Id");
            RenameIndex(table: "dbo.MenuItems", name: "IX_Cart_UserId", newName: "IX_Cart_Id");
            DropPrimaryKey("dbo.Cart");
            AddColumn("dbo.Cart", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Cart", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Cart", "Id");
            AddForeignKey("dbo.MenuItems", "Cart_Id", "dbo.Cart", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "Cart_Id", "dbo.Cart");
            DropPrimaryKey("dbo.Cart");
            AlterColumn("dbo.Cart", "UserId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Cart", "Id");
            AddPrimaryKey("dbo.Cart", "UserId");
            RenameIndex(table: "dbo.MenuItems", name: "IX_Cart_Id", newName: "IX_Cart_UserId");
            RenameColumn(table: "dbo.MenuItems", name: "Cart_Id", newName: "Cart_UserId");
            AddForeignKey("dbo.MenuItems", "Cart_UserId", "dbo.Cart", "UserId");
        }
    }
}
