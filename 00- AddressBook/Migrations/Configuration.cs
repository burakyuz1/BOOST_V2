namespace _00__AddressBook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_00__AddressBook.Data.AddressBookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_00__AddressBook.Data.AddressBookDbContext context)
        {
            if (!context.People.Any())
            {
                context.People.Add(new Data.Person() { Name = "Can" });
                context.People.Add(new Data.Person() { Name = "Cem" });
                context.People.Add(new Data.Person() { Name = "Kamil" });
            }
        }
    }
}
