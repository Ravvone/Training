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

            ////using the string 
            for (int g = 0; g < girls.Length; ++g)
            {
                Console.WriteLine("my favorite girls are " + (girls[g]));

            }
            Console.ReadKey();

            ////using a array command
            for (int d = 0; d < girls.Length; ++d)
            {
                Array.Sort(girls);
                Console.WriteLine("my favorite girls are " + girls[d]);
            }
            Console.ReadKey();

            ////interoplation can only be used with number based system
            for (int a = 0; a < girls.Length; ++a)
            {
                Console.WriteLine($"my favorite girls are {a}");
            }
            Console.ReadKey();

            //This is the long way to write a array using a loop
            int[] nums = new int[4];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 40;
            nums[3] = 80;

            for (int n = 0; n < nums.Length; ++n)
            {
                Console.WriteLine("THe values of array nums is " + (nums[n]));

            }
            Console.ReadKey();


            char[] letters = { 'm', 'p', 'o', 'm', 'l' };
            
            for(int m =0; m<letters.Length; ++m)
            {
                Console.WriteLine("The value of the letters array are " + ((letters[m])));

            }
            Console.ReadKey();









        }    
    }
}
