namespace MVCBasics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        MenuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cart");
        }
    }
}
