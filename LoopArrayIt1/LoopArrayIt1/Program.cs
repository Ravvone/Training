using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayIt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            int[] pieces = {11,77, 33, 51, 22, 78, 90 };
            
            for (d=0; d< pieces.Length; ++d)
            {
                Console.WriteLine($"The value of the pieces array is currently {(pieces[d])}");
                if (pieces[d]== 51)
                {
                    Console.WriteLine($"We found 51");
                    Console.WriteLine("The loop is over");
                    break;
                    
                }
              
                Console.ReadLine();

            }
            Console.ReadLine();
            
                
         

        }
    }
}
