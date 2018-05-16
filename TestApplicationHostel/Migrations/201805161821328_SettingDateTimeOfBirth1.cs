namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingDateTimeOfBirth1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Guests", "DateOfBirt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guests", "DateOfBirt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Guests", "DateOfBirth");
        }
    }
}
