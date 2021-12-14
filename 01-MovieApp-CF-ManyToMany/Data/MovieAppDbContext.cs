using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MovieApp_CF_ManyToMany.Data
{
    public class MovieAppDbContext : DbContext
    {
        public MovieAppDbContext() : base("name=MovieAppConnection ")
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
