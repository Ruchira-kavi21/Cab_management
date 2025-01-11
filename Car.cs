using CabRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRental
{
    public class Car
    {
        // Properties of the Car class
        public int car_id { get; set; }
        public string model { get; set; }
        public string plate_number { get; set; }
        public bool availability { get; set; }
        
        //encapsulation
        public Car(int car_id, string model, string plate_number, bool availability)
        {
            this.car_id = car_id;
            this.model = model;
            this.plate_number = plate_number;
            this.availability = availability;
        }

    }
}


