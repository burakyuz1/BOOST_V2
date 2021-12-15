namespace _00_CareTaker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CareTakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Food_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Foods", t => t.Food_Id)
                .Index(t => t.Food_Id);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Int(nullable: false),
                        HasOwner = c.Boolean(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Weight = c.Double(nullable: false),
                        Type = c.String(),
                        FoodId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Foods", t => t.FoodId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        Calorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PetCareTakers",
                c => new
                    {
                        Pet_Id = c.Int(nullable: false),
                        CareTaker_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pet_Id, t.CareTaker_Id })
                .ForeignKey("dbo.Pets", t => t.Pet_Id, cascadeDelete: true)
                .ForeignKey("dbo.CareTakers", t => t.CareTaker_Id, cascadeDelete: true)
                .Index(t => t.Pet_Id)
                .Index(t => t.CareTaker_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.CareTakers", "Food_Id", "dbo.Foods");
            DropForeignKey("dbo.PetCareTakers", "CareTaker_Id", "dbo.CareTakers");
            DropForeignKey("dbo.PetCareTakers", "Pet_Id", "dbo.Pets");
            DropIndex("dbo.PetCareTakers", new[] { "CareTaker_Id" });
            DropIndex("dbo.PetCareTakers", new[] { "Pet_Id" });
            DropIndex("dbo.Pets", new[] { "FoodId" });
            DropIndex("dbo.CareTakers", new[] { "Food_Id" });
            DropTable("dbo.PetCareTakers");
            DropTable("dbo.Foods");
            DropTable("dbo.Pets");
            DropTable("dbo.CareTakers");
        }
    }
}
