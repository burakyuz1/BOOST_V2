namespace _00__AddressBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sectionsDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "surname");
            DropColumn("dbo.People", "address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "address", c => c.String(nullable: false));
            AddColumn("dbo.People", "surname", c => c.String(nullable: false));
        }
    }
}
