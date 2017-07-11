using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //string concatenation
            Console.WriteLine("Hello " + name+ " how r u today");
            Console.ReadLine();

            Console.WriteLine("what is your m age");
            string age = Console.ReadLine();

            Console.WriteLine("you are an {0} year old guy", age);

            Console.WriteLine("{0} you are and {1} year old guy", name, age);
            Console.ReadLine();

            Console.WriteLine("are you going out tonight");
            string goingout = Console.ReadLine();
            //string interpalation
            Console.WriteLine($"My name is {name} I am {age} and {goingout} of course");
            Console.ReadLine();
        }
    }
}
