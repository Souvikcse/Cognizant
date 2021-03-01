namespace DemoUploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "city", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "city");
        }
    }
}
