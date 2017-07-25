﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Using 2 arguments here !!!");
            Display(10, 20);
            Console.WriteLine("Using 3 arguments now");
            Display(1, 2, 3);
        }
        public static void Display(int length, int width, int height =1)
        {
            int area = length * width;
            Console.WriteLine($"the {length} * the {width} equals {area}");
            ReadLine();

        }
    }
}
