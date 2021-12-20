using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TreeView
{
    public class Place
    {
        public Place()
        {

        }
        public Place(string name)
        {
            Name = name;
        }
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Name{ get; set; }
        public int? ParentId { get; set; }
        public virtual Place Parent { get; set; }
        public virtual ICollection<Place> Children { get; set; } = new HashSet<Place>();

    }
}
