using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_CareTaker.Model
{
    public class CareTaker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }




        public virtual ICollection<Pet> Pets { get; set; }
        
    }
}
