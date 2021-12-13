using System.Collections.Generic;

namespace _01_TakimEfCf.Model
{
    public class Team
    {
        //public Team()
        //{
        //    this.Students = new HashSet<Student>();
        //}
        public int Id { get; set; }
        public string TeamName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}