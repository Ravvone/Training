using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int input, input2;
            Console.WriteLine("Give me the first number to multiply");
            string num1 = Console.ReadLine();
            int.TryParse(num1, out input);

            Console.WriteLine("give me anthoer number to mulitply");
            string num2 = Console.ReadLine();
            int.TryParse(num2, out input2);

            p.Multiply(input,input2);
            p.Addition(input, input2);
            

            Console.ReadLine();
            

        }
        public void Multiply(int number1, int number2)
        {
            int product = number1 * number2;
            Console.WriteLine($"the product of {number2} and {number1} is {product}.");
        }
        public void Addition(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine($"the sum of {number1} and number {number2} is {sum}");
        }
        public void Divison(int number1, int number2)
        {

        }

    }
}
