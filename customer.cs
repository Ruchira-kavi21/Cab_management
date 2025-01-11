using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRental
{
    internal class customer:Person
    {
        // Properties of the customer class
        public string CurrentLocation { get; set; }
        public string Destination { get; set; }

        public customer(string customerId, string customerName, int contactNumber, string currentLocation, string destination)
            : base(customerId, customerName, contactNumber)
        {
            CurrentLocation = currentLocation;
            Destination = destination;
        }
    }
}
