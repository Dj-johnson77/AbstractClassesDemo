using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() { }
        public bool HasSideCart { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle Drives!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This Motorcycle, Once Again Drives!");
        }
    }
}
