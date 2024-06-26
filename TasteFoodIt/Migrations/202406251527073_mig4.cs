namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        ContactInformationId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        WebsiteUrl = c.String(),
                    })
                .PrimaryKey(t => t.ContactInformationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactInformations");
        }
    }
}
