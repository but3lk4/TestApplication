namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRequiredConventions1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guests", "DateOfBirth", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Guests", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
