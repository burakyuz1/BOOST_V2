using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_HatıraDuvari
{
    class HatiraDbContext : DbContext
    {
        public HatiraDbContext() : base("name = hatiraConnection")
        {

        }
        public DbSet<Hatira> Hatiralar { get; set; }
    }
}
