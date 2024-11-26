namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "NameSurname", c => c.String());
            AddColumn("dbo.Admins", "ImageUrl", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "ImageUrl");
            DropColumn("dbo.Admins", "NameSurname");
        }
    }
}
