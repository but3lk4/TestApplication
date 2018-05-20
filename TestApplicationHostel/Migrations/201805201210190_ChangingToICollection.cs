namespace TestApplicationHostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingToICollection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservationGuests",
                c => new
                    {
                        Reservation_ID = c.Int(nullable: false),
                        Guest_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_ID, t.Guest_ID })
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID, cascadeDelete: true)
                .ForeignKey("dbo.Guests", t => t.Guest_ID, cascadeDelete: true)
                .Index(t => t.Reservation_ID)
                .Index(t => t.Guest_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationGuests", "Guest_ID", "dbo.Guests");
            DropForeignKey("dbo.ReservationGuests", "Reservation_ID", "dbo.Reservations");
            DropIndex("dbo.ReservationGuests", new[] { "Guest_ID" });
            DropIndex("dbo.ReservationGuests", new[] { "Reservation_ID" });
            DropTable("dbo.ReservationGuests");
        }
    }
}
