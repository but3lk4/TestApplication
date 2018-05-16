namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRequiredConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guests", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Guests", "SurName", c => c.String(nullable: false));
            AlterColumn("dbo.Guests", "EMail", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "ReservationCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Reservations", "Currency", c => c.String(nullable: false));
            DropColumn("dbo.Guests", "PhoneNumber");
            DropColumn("dbo.Guests", "Address");
            DropColumn("dbo.Guests", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guests", "City", c => c.String());
            AddColumn("dbo.Guests", "Address", c => c.String());
            AddColumn("dbo.Guests", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Reservations", "Currency", c => c.String());
            AlterColumn("dbo.Reservations", "ReservationCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Guests", "EMail", c => c.String());
            AlterColumn("dbo.Guests", "SurName", c => c.String());
            AlterColumn("dbo.Guests", "Name", c => c.String());
        }
    }
}
