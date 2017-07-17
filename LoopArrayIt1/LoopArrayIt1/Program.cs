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
            int[] pieces = { 11, 77, 33, 51, 22, 78, 90 };

            for (d = 0; d < pieces.Length; ++d)
            {
                Console.WriteLine($"The value of the pieces array is currently {(pieces[d])}");
                if (pieces[d] == 51)
                {
                    Console.WriteLine($"We found 51");
                    Console.WriteLine("The loop is over");
                    break;

                }

                Console.ReadLine();

            }
            Console.ReadLine();


            string[] cars = { "buick", "datsun", "bmw", "chevy", "corvette", "olds" };
            for(int e = 0; e<cars.Length;++e)
            {
                Console.WriteLine($"The value of the cars array is currently {(cars[e])}");
                Console.ReadLine();
                if(cars[e] =="corvette")
                {
                    Console.WriteLine("we found corvette");
                    
                    break;
                }

            }Console.ReadLine();

            string[] watches = { " ardamar", " Cartier", " rolex", " hublot", " patek" };
            for (int g = 0; g < watches.Length; ++g) 
            {
                Console.WriteLine($"The best watches on the market are{(watches[g])}");
                Console.ReadLine();
                if(watches[g] == " patek")
                {
                    Console.WriteLine(" pateks are the most popular watch in the industy as of now");
                    break;
                }

            }Console.ReadLine();

            foreach(string watch in watches)
            {
                Console.WriteLine(watch);
            }
            Console.ReadKey();

            
            
                
         

        }
    }
}
