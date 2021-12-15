namespace _00_CareTaker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init31 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CareTakers", "Food_Id", "dbo.Foods");
            DropIndex("dbo.CareTakers", new[] { "Food_Id" });
            DropColumn("dbo.CareTakers", "Food_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CareTakers", "Food_Id", c => c.Int());
            CreateIndex("dbo.CareTakers", "Food_Id");
            AddForeignKey("dbo.CareTakers", "Food_Id", "dbo.Foods", "Id");
        }
    }
}
