namespace BusTravels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        BoardingPoint = c.String(nullable: false),
                        TravelDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Buses");
        }
    }
}
