using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("what is your age");
            //double num1 = double.Parse(Console.ReadLine());

            //if(num1 >= 1 && num1 <= 10)
            //{
            //    Console.WriteLine("you r just a kid");
            //}
            //else if(num1 >= 11 && num1 <= 20)
            //{
            //    Console.WriteLine("you are teenager");
            //}
            //else if(num1 >=21 && num1 <=35)
            //{
            //    Console.WriteLine("you r getting up there");

            //}
            //else if(num1 >=36 && num1 <= 55)
            //{
            //    Console.WriteLine("you have it figured out by now");

            //}
            //else
            //{
            //    Console.WriteLine("your in the golden age years!!!");

            //}
            //Console.ReadLine();


            Console.WriteLine("How much you tryna spend");
            double paper = double.Parse(Console.ReadLine());

            if (paper >= 5 && paper <= 10)
            {
                Console.WriteLine("I give you half a gram");
            }
            else if(paper >=11 && paper <=20)
            {
                Console.WriteLine("I give you a gram bra");

            }
            else
            {
                Console.WriteLine("holla at me when you got some money peace");
            }
            Console.ReadLine();

        }
    }
}
