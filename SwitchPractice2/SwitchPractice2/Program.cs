using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who the best basketball player");
            string best = Console.ReadLine().ToLower();

            switch(best)
            {
                case "kobe":
                    Console.WriteLine("possibly");
                    break;
                case "lebron":
                    Console.WriteLine("possibly to !");
                    break;
                case "jordan":
                    Console.WriteLine("Most would say");
                    break;
                default:
                    Console.WriteLine("Well it must be eroc !!");
                    break;


            }
            Console.ReadLine();

            int num;
            Console.WriteLine("what was jordans number for the bulls \n 1. 23 \n 2. 32 \n 3. 55");
            string jordannum = Console.ReadLine();
            int.TryParse(jordannum, out num);

            switch(num)
            {
                case 1:
                    Console.WriteLine("You are correct");
                    break;
                case 2:
                    Console.WriteLine("Nope almost");
                    break;
                case 3:
                    Console.WriteLine("Not even close brah");
                    break;
                default:
                    Console.WriteLine("You got to be freaking kidding me");
                    break;

                
            }
            Console.ReadLine();
           

        }
    }
}
