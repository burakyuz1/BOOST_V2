using _00_CareTaker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_CareTaker.Context
{
    public class CareTakerDbContext : DbContext
    {
        public CareTakerDbContext() : base("name=CareTakerDbContext")
        {

        }
        public DbSet<CareTaker> CareTakers { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Pet> Pets { get; set; }

    }
}
