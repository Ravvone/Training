using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice1
{
    class Program
    {

        enum Movies
        {
            Jaws = 1,
            Goodfellas,
            Heat,
            Scarface,
            Godfater,
            Avatar,
            Inception,
            GetOut
        }
        enum Baddies
        {
            Beyonce =1,
            GabrielUnion,
            Nikki,
            Rhianna,
            Jasmine

           
        }



        static void Main(string[] args)
        {
            //int favMovie;
            //Console.WriteLine("Which Movie is your favortie \n 1. Jaws \n 2. Goodfellas \n 3. Heat");
            //string favorite = Console.ReadLine();

            //int.TryParse(favorite, out favMovie);

            //switch((Movies)favMovie)
            //{
            //    case Movies.Jaws:
            //        Console.WriteLine("Jaws was a great movie");
            //        break;
            //    case Movies.Goodfellas:
            //        Console.WriteLine("Goodfellas I never seen");
            //        break;
            //    case Movies.Heat:
            //        Console.WriteLine("Heat I never seen");
            //        break;
            //    default:
            //        Console.WriteLine("That movie did not make our list");
            //        break;


            //}
            //Console.WriteLine("Out of the movie switch statement block");
            //Console.ReadKey();

            int favBaddie;
            Console.WriteLine("Who's the baddest baddie \n 1. Beyonce \n 2. GabrielUnion \n 3. Nikki");
            string BadChicks = Console.ReadLine();
            int.TryParse(BadChicks, out favBaddie);




            switch ((Baddies)favBaddie)
            {
                case Baddies.Beyonce:
                    Console.WriteLine("She bad !!!");
                    break;
                case Baddies.GabrielUnion:
                    Console.WriteLine("She chocolate and she bad");
                    break;
                case Baddies.Nikki:
                    Console.WriteLine("She bad but she a hoe");
                    break;
                default:
                    Console.WriteLine("She not a baddies according to our records");
                    break;
            }
            Console.ReadKey();

        }
    }
}
