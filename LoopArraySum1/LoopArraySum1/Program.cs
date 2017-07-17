using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArraySum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] nums = { 5, 10, 15, 20, 10, 50 };

            for (int q = 0; q < nums.Length; ++q) 
            {
                Console.WriteLine(nums[q]);
                Console.ReadKey();
             
            }
             total = nums.Sum();
            {
                Console.WriteLine(total);
                Console.ReadKey();

            }

        }
    }
}
