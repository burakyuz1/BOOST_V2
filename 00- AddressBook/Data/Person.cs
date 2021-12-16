using System.Collections;
using System.Collections.Generic;

namespace _00__AddressBook.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public int? ParentId { get; set; }
        public virtual Person Parent { get; set; }
        public virtual ICollection<Person> Children { get; set; }

    }
}
