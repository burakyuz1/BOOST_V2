using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_CareTaker.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Calorie { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
