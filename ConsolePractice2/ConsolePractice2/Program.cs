using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favorite amusement park");
            string park = Console.ReadLine();

            Console.WriteLine("Whens the last time you went there");
            string when = Console.ReadLine();

            Console.WriteLine("Did your have fun");
            string did = Console.ReadLine();
            
            if(did == "yes")
            {
                Console.WriteLine($"My favorite amusment part is {park},the last time i went was {when}, {did} I had a good time ");
            }
            else
            {
                Console.WriteLine($"My favorite amusment part is {park},the last time i went was {when}, {did} I didnt have a good time ");

            }
        }
            
        }
    }

