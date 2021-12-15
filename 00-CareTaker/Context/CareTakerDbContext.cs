using _00_CareTaker.Model;
using System.Data.Entity;

namespace _00_CareTaker.Context
{
    public class CareTakerDbContext : DbContext //namespace ekle
    {
        public CareTakerDbContext() : base("name=CareTakerDbContext")
        {
            //ctor
        }
        public DbSet<CareTaker> CareTakers { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Pet> Pets { get; set; }

    }
}
