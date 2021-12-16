namespace _00__AddressBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalarySection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Salary", c => c.Decimal(nullable: false, precision: 20, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Salary");
        }
    }
}
