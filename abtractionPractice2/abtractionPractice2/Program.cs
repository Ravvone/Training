using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abtractionPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvel mar = new Marvel();

            int bravery;
            string speed;

            speed = mar.Justice();
            Console.WriteLine(speed);


            bravery = mar.Scheme();
            Console.WriteLine(bravery);

            Console.ReadLine();
        }
    }
}
