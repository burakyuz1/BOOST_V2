using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_HatıraDuvari
{
    [Table("Hatiralar")]
    class Hatira
    {
        public int Id { get; set; }
        public DateTime OlusturulmaZamani { get; set; } = DateTime.Now;
        public string Icerik { get; set; }

    }
}
