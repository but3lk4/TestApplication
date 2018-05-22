namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingErrors : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Guests", "Reservation_ID", "dbo.Reservations");
            DropIndex("dbo.Guests", new[] { "Reservation_ID" });
            DropColumn("dbo.Guests", "Reservation_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guests", "Reservation_ID", c => c.Int());
            CreateIndex("dbo.Guests", "Reservation_ID");
            AddForeignKey("dbo.Guests", "Reservation_ID", "dbo.Reservations", "ID");
        }
    }
}
