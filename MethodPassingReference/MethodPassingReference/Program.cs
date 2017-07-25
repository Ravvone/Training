using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"In the main method x = {x}");
            DisplayValueParameter(x);
            Console.WriteLine($"In the main method the value of x is now {x}");
            DisplayNewValue(ref x);
            Console.WriteLine($"The value of the new value is {x}");
            Console.ReadKey();
            
            

        }
        private static void DisplayValueParameter(int x)
        {
            x = 1000;
            Console.WriteLine($"We are in the Display Value Parameter Method \nWhere x = {x}");
        }
        private static void DisplayNewValue(ref int n)
        {
            n = 1000;
            Console.WriteLine($"We are in the Display New Value Method\nWhere n = {n}");
        }
        
    }
}
