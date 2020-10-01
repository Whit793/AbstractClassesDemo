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

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car accord = new Car() { HasTrunk = true, Make = "Honda", Model = "Accord", Year = 2004 };
            Motorcycle tR6 = new Motorcycle() { HasSideCar = false, Make = "Triumph", Model = "TR6", Year = 1961 };

            Vehicle convertible = new Car() { HasTrunk = true, Make = "Pontiac", Model = "GTO", Year = 1966 };
            Vehicle spyder = new Car() { HasTrunk = false, Make = "Porsche", Model = "908", Year = 1969 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(accord);
            vehicles.Add(tR6);
            vehicles.Add(convertible);
            vehicles.Add(spyder);

            foreach (var vehi in vehicles)
            {
                Console.WriteLine($"This beautiful {vehi.Make} {vehi.Model} was made in the year {vehi.Year}");

                vehi.DriveAbstract();
                Console.WriteLine("You should probably go catch it");
                Console.WriteLine("-------");

            }



            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
