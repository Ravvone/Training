using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPracticeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Swiss sw = new Swiss();
            Watches ws = new Watches();

            string Model, Make, TickType;
            Model = sw.Type();
            Make = sw.Build();
            TickType = sw.Mechanics();


            ws.WhichONe();
            Console.ReadKey();


            Console.WriteLine($"Todays watch is a {Model}\n{Make}\n{TickType}");

            Console.ReadLine();

            


        }
    }
    public class Watches
    {
        public void WhichONe()
        {
            Console.WriteLine("which watch will it be for you today sir ?");

        }



    }
}
