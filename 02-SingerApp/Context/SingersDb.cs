using _02_SingerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SingerApp.Context
{
    internal class SingersDb : DbContext
    {
        public SingersDb():base("name = SingerConnectionString")
        {

     
        }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Nation> Nations { get; set; }
    }
}
