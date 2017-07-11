using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mirror Mirror on the wall who is the fairest of them all");
            string fairest = Console.ReadLine().ToLower();

            if(fairest == "me")
            {
                Console.WriteLine("You got that damn right");
            }
            else if(fairest == "you")   
            {
                Console.WriteLine("You need to have more self esteem");
            }
            else
            {
                Console.WriteLine("You got to be kidding me");
            }
            Console.WriteLine($"Why do you thing its {fairest}?");

            Console.ReadLine().ToLower();

         

        }
    }
}
