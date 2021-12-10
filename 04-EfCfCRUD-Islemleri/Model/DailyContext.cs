using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EfCfCRUD_Islemleri.Model
{
    internal class DailyContext : DbContext
    {
        //Veri tabanı ismi, bağlantısı
        public DailyContext() : base("server = . ; database = DailyDb ; integrated security = true")
        {

        }
        public DbSet<Entry> Entries { get; set; }
    }
}
