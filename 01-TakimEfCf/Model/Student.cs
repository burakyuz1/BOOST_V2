using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TakimEfCf.Model
{

    public class Student
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }

        //TeamId Team'ın foreign key olduğunu gösterir,
        //Herhangi bir isim versek, gelenek bozulur, nereye foreign key olacağını bilemez.

    }
}
