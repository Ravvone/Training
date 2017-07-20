using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Resturants r = new Resturants();
            Fashion f = new Fashion();

            Console.WriteLine("This is the main method landing page");

            r.Chipotle();
            f.Pants();
            




            Console.ReadLine();

        }

        public static void Addition()
        {

        }

        public static void Mulitipication()
        {

        }
    } 
    class Fashion
    {
        public void Shirts()
        {
            Console.WriteLine("vneck");
            Console.WriteLine("tee");
            Console.WriteLine("polo");

        }
        public void Pants()
        {
            Console.WriteLine("Balmains are going out of style");

        }
        public void Shoes()
        {

        }
    }
    
    

}
