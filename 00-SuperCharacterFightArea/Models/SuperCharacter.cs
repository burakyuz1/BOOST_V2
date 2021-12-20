using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_SuperCharacterFightArea.Models
{
    public class SuperCharacter
    {
        public SuperCharacter()
        {
            Health = 100;
            IsAlive = true;
            ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "charDefault.png";
            Abilities = new List<Ability>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }
        public List<Ability> Abilities { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} Health: {Health}";
        }
    }
}
