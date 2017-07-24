using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "jones";
            Console.WriteLine($"Me and Mrs {x} gotta thing going on.");
            Console.ReadKey();
            Freeman(ref x);
            Console.ReadKey();
            Jones();
            Console.ReadKey();
            Console.WriteLine("Till I call her back again");
            Console.ReadKey();
            Again();
            Console.WriteLine($"Me and Mrs. {x}");
            Console.ReadKey();
             x = "jones";
            Console.WriteLine($"Me and Mrs. {x}");
            Console.ReadKey();

        }
        private static void Freeman(ref string m)
        {
             m = "Freeman";
            Console.WriteLine($"But when she with me she's Ms.{m}");
        }
        private static void Jones()
        {
            string v = "Jones";
            Console.WriteLine($"Then I send her back she's Ms.{v} again");
        }
        private static void Again()
        {
            
            Console.WriteLine("Yea we gotta thing going on");

        }
    }
}
