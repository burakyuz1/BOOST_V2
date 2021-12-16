namespace _00_CareTaker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class news : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "Calorie", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foods", "Calorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
