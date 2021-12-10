using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EfCfCRUD_Islemleri.Model
{
    [Table("Entries")]
    internal class Entry //Entity Class'ı
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
