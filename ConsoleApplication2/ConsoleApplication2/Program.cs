using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ca = new Car();

            Console.WriteLine($"Car mileage is {ca.GetMileage()}");
            Console.WriteLine($"Car color is {ca.GetColor()}");
            Console.WriteLine($"The Secret fourmula is {ca.DisplayEngineFourmula()}");

            Console.ReadLine();


        }
    }
}
