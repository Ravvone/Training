using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
           for (i= 1; i<= 100; i++)
            {

                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz)
                    Console.WriteLine("fizz");
                else if (buzz)
                    Console.WriteLine("buzz");
                else if (fizz && buzz)
                    Console.WriteLine("fizzbuzz");
                else
                    Console.WriteLine(i);
                   
                  
            }
            Console.ReadKey();
        } 
    }
}
