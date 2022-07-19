using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
          

            var car1 = new Car()
            {
                NumberOfWheels = 4,
                Make = "BMW",
                Model = "M3",
                SeatCount = 4,
                Logo = "Drive Faster",
                CompanyName = "Luxe Master",
                HasTrunk = true,
                HasSubWoofers = true,
            };


            var truck1 = new Truck()
            {
                NumberOfWheels = 8,
                Make = "Bulldoze",
                Model = "Hammer",
                SeatCount = 2,
                Logo = "Deliver Faster",
                CompanyName = "Tonka",
            };

            var suv1 = new SUV()
            {
                NumberOfWheels = 2,
                Make = "BMW",
                Model = "M3",
                SeatCount = 4,
                Logo = "Drive Faster",
                CompanyName = "Luxe Master",
                CargoHoldSize = "5 tons",
                HasConvertibleRoof = false,
            };

            //Creatively display and organize their values

            var vehicles = new List<IVehicle>()
            {
                car1,
                truck1,
                suv1
            };

            foreach (var item in vehicles)
            {
                Console.WriteLine($"This is my vehicle's attributes:");
                Console.WriteLine($"Number of Wheels: {item.NumberOfWheels} | Make: {item.Make} | Model: {item.Model} | Seat Count: {item.SeatCount} | Logo: {item.Logo} |" +
                    $"Company Name: {item.CompanyName} | ");
                if (item == car1)
                {
                    Console.WriteLine($"Has Trunk: {car1.HasTrunk} | Has Subwoofers: {car1.HasSubWoofers}");
                    Console.WriteLine("----------------------------\n");
                }
                else if (item == truck1)
                {
                    Console.WriteLine($"Bed Size: {truck1.BedSize} | Manual or Automatic: {truck1.ManualOrAutomatic}");
                    Console.WriteLine("----------------------------\n");
                }
                else if (item == suv1)
                {
                    Console.WriteLine($"Cargo Hold Size: {suv1.CargoHoldSize} | Has Convertible Roof: {suv1.HasConvertibleRoof}");
                    Console.WriteLine("----------------------------\n");
                }
            }
            
        }
    }
}
