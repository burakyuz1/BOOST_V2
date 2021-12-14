using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MovieApp_CF_ManyToMany.Data
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies{ get; set; }
    }
}
