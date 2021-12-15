using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MigrationExcercises.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base("name=ApplicationDbContext")
        {
            Database.SetInitializer(new DbInitialStrategy());
        }
        public DbSet<Person> People{ get; set; }
    }
}
