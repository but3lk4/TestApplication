namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FightWitgForeignKey : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Guests", new[] { "Reservation_ID" });
            RenameColumn(table: "dbo.Reservations", name: "Reservation_ID", newName: "Guest_ID");
            CreateIndex("dbo.Reservations", "Guest_ID");
            DropColumn("dbo.Guests", "Reservation_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guests", "Reservation_ID", c => c.Int());
            DropIndex("dbo.Reservations", new[] { "Guest_ID" });
            RenameColumn(table: "dbo.Reservations", name: "Guest_ID", newName: "Reservation_ID");
            CreateIndex("dbo.Guests", "Reservation_ID");
        }
    }
}
