using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRealNumber;
            int secondRealNumber;
            double firstDouble;


            Console.WriteLine("Give me a number to work with");
            string firstNum = Console.ReadLine();

            Console.WriteLine("give me a double to work with");
            string firstDub = Console.ReadLine();

            Console.WriteLine("give me a second number to work with");
            string secondNum = Console.ReadLine();



            double.TryParse(firstDub, out firstDouble);
            int.TryParse(firstNum, out firstRealNumber);
            int.TryParse(secondNum, out secondRealNumber);


            MultiplyIntergers();
            MultiplyIntergers(firstRealNumber);
            MultiplyIntergers(firstRealNumber, secondRealNumber);
            MultiplyIntergers(firstDouble);

            //MultiplyIntergers();

        }








        public static void MultiplyIntergers()
        {
            int firstNum = 0;
            Console.WriteLine($"The first real number wit no intergers is here {firstNum}");
            Console.ReadLine();
        }
        public static void MultiplyIntergers(int number1)
        {
            Console.WriteLine($"The first real number with 1 interger is here {number1}");
            Console.ReadLine();

        }
        public static void MultiplyIntergers(int val1, int val2)
        {
            Console.WriteLine("The first real number with 2 intergers is here");
            int product = val1 * val2;
            Console.WriteLine($"The product of {val1} and {val2} is {product}");
            Console.ReadLine();
        }
        public static void MultiplyIntergers(double valDouble)
        {
            Console.WriteLine($"The first double value is {valDouble}");
            Console.ReadLine();
        }


    }
}
