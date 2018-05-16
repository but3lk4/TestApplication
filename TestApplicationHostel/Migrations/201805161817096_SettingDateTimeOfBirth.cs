namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingDateTimeOfBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "DateOfBirt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Guests", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guests", "DateOfBirth", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Guests", "DateOfBirt");
        }
    }
}
