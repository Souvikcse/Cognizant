namespace DemoUploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Sid = c.Int(nullable: false, identity: true),
                        sname = c.String(),
                        sphoto = c.String(),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
