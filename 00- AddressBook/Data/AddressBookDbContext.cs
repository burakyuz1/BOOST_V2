using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00__AddressBook.Data
{
    public  class AddressBookDbContext : DbContext
    {
        public AddressBookDbContext() : base("name=AddressBookDbContext")
        {
            //Database.SetInitializer<AddressBookDbContext>(null);
        }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Person>()
                .Property(x => x.Salary)
                .HasPrecision(20, 2);

     
        }
        
    }
}
