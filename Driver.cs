using FormClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRental
{
    internal class Driver:Person
    {
        // Properties of the Driver class
        public bool DriverAvailability { get; set; }

        public Driver(string driverId, string driverName, int contactNumber, bool driverAvailability)
            : base(driverId, driverName, contactNumber)
        {
            DriverAvailability = driverAvailability;
        }

    }

    
}
