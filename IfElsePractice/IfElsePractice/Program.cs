using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite Color");
            string favcolor = Console.ReadLine().ToUpper();

            if (favcolor == "RED")
            {
                Console.WriteLine("red is good");
            }
            else
            {
                Console.WriteLine("pick again");
            }


        }
    }
}
