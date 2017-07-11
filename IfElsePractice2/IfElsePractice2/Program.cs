using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favorite car ?");
            string car = Console.ReadLine().ToLower();


            if(car == "maserati")
            {
                Console.WriteLine("That is a nice car");
            }
            
            else if(car == "honda") 
            {
                Console.WriteLine("Your not trying hard enough");
            }
            else
            {
                Console.WriteLine("You should dream bigger bra");
            }
            Console.ReadLine();
        }
    }
}
