using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1900;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Year";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually driving");

        }




    }
}
