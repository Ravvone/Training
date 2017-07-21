using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Class1
    {
        public void Multi(int num1, int num2)
        {
            int num3 = num1 * num2;
            Console.WriteLine($"You wanna know what the answer is");
       
            Console.ReadLine();
            Console.WriteLine("Do you really wanna know");
            Console.ReadLine();
          
            Console.WriteLine($"{num3}");
            Console.ReadLine();
            Console.WriteLine("dont say I never did anything for you");
            Console.ReadKey();
        }
        public void Divi(int num1, int num2)
        {
            int num3 = num1 / num2;
            Console.WriteLine($"{num3} is the answer wow you didnt know that ?? puhahaha");
            Console.ReadLine();
        }

      

        public void Add(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine($"Bam the total is {num3}");
        }
        public void Subtra(int num1, int num2)
        {
            int num3 = num1 - num2;
            Console.WriteLine($" Wylaa the total is {num3}");
        }

        Program p = new Program();
        
        









    }

        
}
