namespace _00__AddressBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ParentId", c => c.Int());
            CreateIndex("dbo.People", "ParentId");
            AddForeignKey("dbo.People", "ParentId", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "ParentId", "dbo.People");
            DropIndex("dbo.People", new[] { "ParentId" });
            DropColumn("dbo.People", "ParentId");
        }
    }
}
