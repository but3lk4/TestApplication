namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingDateTimeOfBirth3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guests", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Guests", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
