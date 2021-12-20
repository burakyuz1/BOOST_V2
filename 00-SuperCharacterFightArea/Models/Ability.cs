using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_SuperCharacterFightArea.Models
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AmountOfAbility { get; set; }

        public int MySuperCharacterId { get; set; }
        public SuperCharacter SuperCharacter { get; set; }
    }
}
