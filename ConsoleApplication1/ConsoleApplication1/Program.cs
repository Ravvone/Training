﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt, num1, num2;
            float result;

        label:

          
            Console.WriteLine("\nPress 1 for add");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for Division");

            Console.Write("\n\nEnter first number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter your option:\t");
            opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                result = num1 + num2;
                Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
            }
            else if (opt == 2)
            {
                result = num1 - num2;
                Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
            }
            else if (opt == 3)
            {
                result = num1 * num2;
                Console.WriteLine("\n{0} x {1} = {2}", num1, num2, result);
            }
            else if (opt == 4)
            {
                result = (float)(num1 / num2);
                Console.WriteLine("\n{0} / {1} = {2}", num1, num2, result);
            }
            else
            {
                Console.WriteLine("Invalid option. Try again");
                goto label;
            }
            Console.ReadLine();
        } 
    }
}
