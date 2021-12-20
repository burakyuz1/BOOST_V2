using System.ComponentModel.DataAnnotations;

namespace _01_EagerLazyLoading.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
