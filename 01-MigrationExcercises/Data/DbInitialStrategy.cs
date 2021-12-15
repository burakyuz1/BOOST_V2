using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MigrationExcercises.Data
{
    public class DbInitialStrategy : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext db)
        {
            if (!db.People.Any())
            {
                db.People.Add(new Person() { Name = "Ali" });
                db.People.Add(new Person() { Name = "Kemal" });
                db.People.Add(new Person() { Name = "Haydar" });
                db.SaveChanges();
            }
          
        }
    }
}
