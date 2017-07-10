using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite name");
            string dude = Console.ReadLine();
            Console.WriteLine($"My name is {dude}");
            Console.ReadKey();

            Console.WriteLine("What is your age");
            string age = Console.ReadLine();

            Console.WriteLine("What's your Street name");
            string streetName = Console.ReadLine();

            Console.WriteLine("whats you email address");
            string email = Console.ReadLine();

            Console.WriteLine($"My age is {age}, my street name is {streetName}, my email address is {email} ");







        }
    }
}
