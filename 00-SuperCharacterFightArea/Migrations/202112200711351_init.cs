namespace _00_SuperCharacterFightArea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        AmountOfAbility = c.Decimal(nullable: false, precision: 5, scale: 2),
                        MySuperCharacterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SuperCharacters", t => t.MySuperCharacterId, cascadeDelete: true)
                .Index(t => t.MySuperCharacterId);
            
            CreateTable(
                "dbo.SuperCharacters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ImagePath = c.String(nullable: false, maxLength: 255),
                        Health = c.Int(nullable: false),
                        IsAlive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abilities", "MySuperCharacterId", "dbo.SuperCharacters");
            DropIndex("dbo.Abilities", new[] { "MySuperCharacterId" });
            DropTable("dbo.SuperCharacters");
            DropTable("dbo.Abilities");
        }
    }
}
