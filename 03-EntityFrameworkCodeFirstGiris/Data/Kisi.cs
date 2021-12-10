using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFrameworkCodeFirstGiris.Data
{
    [Table("Kisiler")]
    internal class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }

    }
}
