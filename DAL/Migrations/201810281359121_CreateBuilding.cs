namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBuilding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        BuildingID = c.Int(nullable: false, identity: true),
                        Cat = c.String(),
                        Adress_City = c.String(),
                        Adress_Street = c.String(),
                        Adress_Zip = c.String(),
                        Adress_Country = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID);
            
            CreateTable(
                "dbo.Appartments",
                c => new
                    {
                        BuildingID = c.Int(nullable: false),
                        AppartFloor = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        BuildingID = c.Int(nullable: false),
                        PoolSize = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        BuildingID = c.Int(nullable: false),
                        NbrOfRegisters = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Townhouses",
                c => new
                    {
                        BuildingID = c.Int(nullable: false),
                        NbrOfNeighbors = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        BuildingID = c.Int(nullable: false),
                        Height = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Villas",
                c => new
                    {
                        BuildingID = c.Int(nullable: false),
                        NbrOfRooms = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.BuildingID)
                .ForeignKey("dbo.Buildings", t => t.BuildingID)
                .Index(t => t.BuildingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Villas", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Warehouses", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Townhouses", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Shops", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Houses", "BuildingID", "dbo.Buildings");
            DropForeignKey("dbo.Appartments", "BuildingID", "dbo.Buildings");
            DropIndex("dbo.Villas", new[] { "BuildingID" });
            DropIndex("dbo.Warehouses", new[] { "BuildingID" });
            DropIndex("dbo.Townhouses", new[] { "BuildingID" });
            DropIndex("dbo.Shops", new[] { "BuildingID" });
            DropIndex("dbo.Houses", new[] { "BuildingID" });
            DropIndex("dbo.Appartments", new[] { "BuildingID" });
            DropTable("dbo.Villas");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Townhouses");
            DropTable("dbo.Shops");
            DropTable("dbo.Houses");
            DropTable("dbo.Appartments");
            DropTable("dbo.Buildings");
        }
    }
}
