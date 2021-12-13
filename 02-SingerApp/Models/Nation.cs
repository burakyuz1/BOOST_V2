using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SingerApp.Models
{
    internal class Nation
    {
        public int Id { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<Singer> Singers { get; set; }
    }
}
