using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SingerApp.Models
{
    internal class Singer
    {
        public int Id { get; set; }
        public string SingerName { get; set; }
        public int? NationId { get; set; }
        public virtual Nation Nation { get; set; }
    }
}
