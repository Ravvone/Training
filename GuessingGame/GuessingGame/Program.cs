using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.working();
            talking();
            p.trapping();
            Console.ReadKey();
            Vaction V = new Vaction();
            V.Bahamas();
            V.Cancoon();
            Console.ReadKey();

            
                                                     
        }
        public void working()
        {
            Console.WriteLine("I been trapping since the 6th grade");

        }
        public static void talking()
        {
            Console.WriteLine("Im outside the trap house");
        
        }

        public void trapping()
        {
            Console.WriteLine("Flipping bout two to three bricks");
           

        }
        
        

        
    }


    
    
}
