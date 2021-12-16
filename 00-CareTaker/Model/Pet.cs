using _00_CareTaker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_CareTaker.Model
{
    public class Pet
    {
        public Pet()
        {
            CareTakers = new List<CareTaker>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool HasOwner { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public int? FoodId { get; set; }
        public virtual Food Food { get; set; }
        public virtual ICollection<CareTaker> CareTakers { get; set; }

    }
}
