using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "2020";
        public string Make { get; set; } = "Default value";
        public string Model { get; set; } = "Default value";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
