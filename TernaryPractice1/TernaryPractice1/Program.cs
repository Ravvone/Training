using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("what is your favorite soprot");
            //string sport = Console.ReadLine().ToLower();
            //string favSport = (sport == "hockey" || sport == "football" || sport == "golf") ? "great choice" : "bad choice";
            //Console.WriteLine(favSport);
            //Console.ReadLine();

            //Console.WriteLine("what kind of foods do you like");
            //string food = Console.ReadLine().ToLower();
            //string food2 = Console.ReadLine().ToLower();
            //string foodChoice = (food == "chicken") && (food2 == "shrimp") ? "good choice" : "bad choice";
            //Console.WriteLine(foodChoice);
            //Console.ReadLine();


            Console.WriteLine("Who the best");
            string best = Console.ReadLine().ToLower();
            string best2 = Console.ReadLine().ToLower();


            string thebest = (best == "we" && best2 == "the best") ? "that's damn right" : "you trippin";
            Console.WriteLine(thebest);
            Console.WriteLine($"You already know {best} {best2}");
            Console.ReadLine();


        }
    }
}
