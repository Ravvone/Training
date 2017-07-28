using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessModifiers1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Movies title = new Movies();

            int number1 = 200;
            int number2 = 300;

            int total = TotalNumber(number1, number2);
            int sum = PlusNumber(number1, number2);
            double answer = DivideNumber(number1, number2);

            Console.WriteLine(sum);
            Console.WriteLine(answer);
            Console.WriteLine(total);
            Console.ReadLine();
        }
        public static int TotalNumber(int n1, int n2)
        {
            int product = n1 * n2;
            return product;
        }
        public static int PlusNumber(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;

        }
        public static double DivideNumber(int n1, int n2)
        {
            double answer = n1 / n2;
            return answer;
        }
    }
    
}
