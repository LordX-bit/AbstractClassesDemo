using Microsoft.VisualBasic;
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
            var Vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var Midsize = new Car() { Model = "Trailblazer", Make = "Chevrolet", Year = "2009" };
            
            var motorcycle = new Motorcycle() { Year = "2006", Make = "Honda", Model = "Raptor", };
            Vehicle sedan = new Car() { Model = "sentra", Make = "Nissan", Year = "2020" };
           
            Vehicle sport = new Car() {Year = "2008", Make = "Toyota", Model = "Camry", };





            //* Add the 4 vehicles to the list
            // * Using a foreach loop iterate over each of the properties
            // */
            Vehicles.Add(Midsize);
            Vehicles.Add(motorcycle);
            Vehicles.Add(sedan);
            Vehicles.Add(sport);
            //*

            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine("Vehicle Information");
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                //Console.WriteLine("Vehicle Information");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();

            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
