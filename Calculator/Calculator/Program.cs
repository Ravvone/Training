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
            Class1 c = new Class1();
            int num1, num2, choice;
          
        SmartCalculator:


            Console.WriteLine("Give me a number so I can show you some magic");
            num1 = Convert.ToInt32(Console.ReadLine());
          
           Console.WriteLine("Another One.. Dj Khaled Voice");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Do you want it done \n 1. Add \n 2.Subtract \n 3. Multiply \n 4.Divide");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
           
            

            if (choice == 1)
            {
                c.Add(num1, num2);
            }
            else if(choice == 2)
            {
                c.Subtra(num1, num2);
            }
            else if(choice == 3)
            {
                c.Multi(num1, num2);
            }
            else if(choice == 4)
            {
                c.Divi(num1, num2);

            }
            else
            {
                Console.WriteLine("You messed up bruh");

            }
            Console.ReadLine();
            Console.Clear();
         
            Console.WriteLine("Do you want to go again yes or no ?");
            string opt = Console.ReadLine();
           
              
            if(opt == "yes")
            {
                goto SmartCalculator;

            }
            else
            {
                Console.WriteLine("You'll be back.....");
            }
            Console.ReadKey();
            Console.Clear();
                  

          
                    


            

        }
    }
}
