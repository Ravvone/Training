using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite color");
            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "red":
                    Console.WriteLine("Red is an ok color");
                    break;
                case "blue":
                    Console.WriteLine("Blue is an ok color");
                    break;
                case "pink":
                    Console.WriteLine("pink is an ok color");
                    break;
                default:
                    Console.WriteLine("we dont understand your answer");
                    break;
            }
            Console.ReadLine();

            Console.WriteLine("What is your favorite pasta dish /n 1. Lasagne /n 2. Spaghetti / 3. ravioli");
            int FoodChoice = Convert.ToInt32(ReadLine().ToUpper());
            ;
            //int food = int.Parse(Console.ReadLine())

            switch(FoodChoice)
            {
                case 1:
                    Console.WriteLine("Lasagne is fantastic!!!");
                    break;
                case 2:
                    Console.WriteLine("Spaghetti is great");
                    break;
                case 3:
                    Console.WriteLine("Raviolli is good");
                    break;
                default:
                    Console.WriteLine("That's not a good pasta choice");
                    break;

                
               
            }
            Console.ReadLine();

        }
    }
}
