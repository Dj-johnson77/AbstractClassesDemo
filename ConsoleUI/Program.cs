using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car focus = new Car() { HasTrunk = true, make = "Ford", model = "Focus", year = 2022 };
            Motorcycle harley = new Motorcycle() { HasSideCart = true, year = 2022, model = "Cruiser", make = "Harley-Davidson" };
            Vehicle chevy = new Car() { make = "Chevrolet", model = "Corvette", year = 2022 };
            Vehicle dodge = new Car() { year = 2022, model = "Dodge", make = "RAM", HasTrunk = false };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(chevy);
            vehicles.Add(focus);
            vehicles.Add(dodge);
            vehicles.Add(harley);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make : {veh.make} , Model : {veh.model}, Year : {veh.year}");
                veh.DriveAbstract();
                veh.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle

            

            #endregion            
            Console.ReadLine();
        }
    }
}
