using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MovieApp_CF_ManyToMany.Data
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public decimal Rating { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Genre> Genres{ get; set; }

    }
}
