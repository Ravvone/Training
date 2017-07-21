using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, choice;
            float num3;
        Calculator:


            Console.WriteLine("Give me a number so I can show you some magic");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Another One.. Dj Khaled Voice");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want it done \n 1. Add \n 2.Subtract \n 3. Multiply \n 4.Divide");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                num3 = num1 + num2;
                Console.WriteLine($"Bam the total is {num3}");
            }
            else if(choice == 2)
            {
                num3 = num1 - num2;
                Console.WriteLine($" Wylaa the total is {num3}");
            }
            else if(choice == 3)
            {
                num3 = num1 * num2;
                Console.WriteLine($"You wanna know what the answer is");
                Console.ReadLine();
                Console.WriteLine("Do you really wanna know");
                Console.ReadLine();
                Console.WriteLine($"{num3}");
                Console.ReadLine();
                Console.WriteLine("dont say I never did anything for you");
            }
            else if(choice == 4)
            {
                num3 = num1 / num2;
                Console.WriteLine($"{num3} is the answer wow you didnt know that ?? puhahaha");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("???????");
                goto Calculator;

            }
            Console.ReadLine();
                  

          
                    


            

        }
    }
}
