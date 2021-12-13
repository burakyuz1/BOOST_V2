using _01_TakimEfCf.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TakimEfCf.Context
{
    public class FanManagementDbContext : DbContext
    {
        public FanManagementDbContext() : base("name = connectionName")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
