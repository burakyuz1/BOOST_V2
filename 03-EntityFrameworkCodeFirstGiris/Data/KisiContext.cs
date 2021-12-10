using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFrameworkCodeFirstGiris.Data
{
    internal class KisiContext : DbContext
    {
        public DbSet<Kisi> Kisiler { get; set; }

    }
}
