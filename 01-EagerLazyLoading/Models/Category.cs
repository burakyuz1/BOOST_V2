using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _01_EagerLazyLoading.Models
{
    public  class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]

        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
