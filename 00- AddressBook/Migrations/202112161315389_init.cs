namespace _00__AddressBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "address");
        }
    }
}
