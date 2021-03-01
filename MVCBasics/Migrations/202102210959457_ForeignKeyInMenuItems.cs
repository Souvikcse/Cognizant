namespace MVCBasics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyInMenuItems : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.MenuItems", name: "Cart_Id", newName: "CartId");
            RenameIndex(table: "dbo.MenuItems", name: "IX_Cart_Id", newName: "IX_CartId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.MenuItems", name: "IX_CartId", newName: "IX_Cart_Id");
            RenameColumn(table: "dbo.MenuItems", name: "CartId", newName: "Cart_Id");
        }
    }
}
