using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //i < 10;
            //i++; 

            int[] numbers = { 2, 4, 88, 11, 55, 99, 165 };
            string[] stars = { "aeyonce", "ahianna", "aodonna", "another hoe" };

            int[] dollars = { 20, 40, 60, 80, 100 };



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is {i}");
            }

            //Console.ReadLine();

            //for (int k = 0; k < stars.Length; ++k)
            //{
            //    Console.WriteLine("The stars are " + (stars[k]));
            //}
            //Console.ReadLine();

            for (int g = 0; g < dollars.Length; ++g)
            {
                Console.WriteLine("When im trapping my money be flippin like " + (dollars[g]));

            }
            Console.ReadLine();

            for (int d = 0; d < numbers.Length; ++d)
            {
                Array.Reverse(numbers);
                Console.WriteLine(numbers[d]);
            }
            Console.ReadLine();

            for (int e = 0; e < stars.Length; ++e)
            {
                Array.Reverse(stars);
                Console.WriteLine(stars[e]);
            }
            Console.ReadLine();












        }
    }
}
