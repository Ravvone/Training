using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Resturants
    {
        public static void FamousDaves()
        {
            Fashion fash = new Fashion();
            Resturants r = new Resturants();
           
            fash.Pants();
            fash.Shirts();
            r.Chipotle();
            
           
            Console.ReadLine();

        }
        public void Chipotle()
        {
            Console.WriteLine("We make burittos");
        }
        public void Benihana()
        {
            Console.WriteLine("we have all black people now");
            Console.ReadLine();
        }
        
    }
}
