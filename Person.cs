using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRental
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int ContactNumber { get; set; }

        public Person(string id, string name, int contactNumber)
        {
            Id = id;
            Name = name;
            ContactNumber = contactNumber;
        }
    }
}
