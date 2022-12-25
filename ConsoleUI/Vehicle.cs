using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {

        }
        public int year { get; set; } = 1;
        public string make { get; set; } = "Default Make";
        public string model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This vehicle drives!");
        }

       

    }
}
