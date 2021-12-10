using _03_EntityFrameworkCodeFirstGiris.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFrameworkCodeFirstGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new KisiContext())
            {
                if (!db.Kisiler.Any())
                {
                    db.Kisiler.Add(new Kisi() { Ad = "Mustafa" });
                    db.Kisiler.Add(new Kisi() { Ad = "Halil" });
                    db.SaveChanges();
                }
                foreach (Kisi kisi in db.Kisiler)
                {
                    Console.WriteLine(kisi.Id + " " + kisi.Ad);
                }
            }

            Console.ReadLine();
        }
    }
}
