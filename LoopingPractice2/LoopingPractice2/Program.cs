using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] girls = { "india", "shinia", "quishonti", "shannon" };

            //using the string 
            for (int g = 0; g < girls.Length; ++g)
            {
                Console.WriteLine("my favorite girls are " + (girls[g]));

            }
            Console.ReadKey();

            //using a array command
            for (int d = 0; d < girls.Length; ++d)
            {
                Array.Sort(girls);
                Console.WriteLine("my favorite girls are " + girls[d]);
            }
            Console.ReadKey();

            //interoplation can only be used with number based system
            for (int a = 0; a < girls.Length; ++a)
            {
                Console.WriteLine($"my favorite girls are {a}");
            }
            Console.ReadKey();




        }    
    }
}
