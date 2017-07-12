using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePracticeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number bro");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);

            Console.WriteLine("Give me another number bro");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            if (num1 > num2)
            {
                Console.WriteLine($"first number is greater than your second number");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }

            Console.ReadLine();
        }
    }
}
