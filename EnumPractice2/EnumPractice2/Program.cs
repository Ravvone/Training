using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice2
{
    enum Burgers
    {
     Whopper =1,
     BigMac,
     Single,
    }

    class Program
    {
        public static void Wendys()
        {
            Console.WriteLine("Wendys is aiight ");
        }
        public static void BurgerKing()
        {
            Console.WriteLine("Burger King is poison");
        }
        public static void McDonalds()
        {
            Console.WriteLine("Mcdonalds is like eating a rock");
        }

        static void Main(string[] args)
        {
            int BChoice;
            Console.WriteLine("Which burger is your favorite \n 1. Whopper \n 2. BigMac \n 3. Single");
            string sandwich = Console.ReadLine();
            int.TryParse(sandwich, out BChoice);

            
              
            switch((Burgers)BChoice)
            {
                case Burgers.Whopper:
                    BurgerKing();
                   break;
                case Burgers.BigMac:
                    McDonalds();
                    break;
                case Burgers.Single:
                    Wendys();
                    break;
                default:
                    break;


            }
            Console.ReadKey();
            
        }
    }
}
