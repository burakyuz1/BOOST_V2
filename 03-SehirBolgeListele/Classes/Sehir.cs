using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SehirBolgeListele.Classes
{
    internal class Sehir
    {
        public int Id { get; set; }
        public int BolgeId { get; set; }
        public string SehirAd { get; set; }
        public int Nufus { get; set; }


        public override string ToString()
        {
            return $"{SehirAd} Plaka:{Id:00} Nufus:{Nufus:n0}";
        }
    }
}
