using System;
using System.Collections.Generic;
using System.Text;

//In each of your car, truck, and suv classes

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set;  }
        public int SeatCount { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public string BedSize { get; set; }
        public string ManualOrAutomatic { get; set; }
    }
}
