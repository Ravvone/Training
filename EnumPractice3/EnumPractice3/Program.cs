using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice3
{
    enum Vodka
    {
     Ciroc =1,
     Titos,
     Bevidere

    }


    class Program
    {
        public static void Ciroc()
        {
            Console.WriteLine("Ciroc gives you a headache");
        }
        public static void Titos()
        {
            Console.WriteLine("Titos doesnt give you a headache");
        }
        public static void Bevidere()
        {
            Console.WriteLine("Belvi is so 1999");
        }
        static void Main(string[] args)
        {
            int Liqlac;
            Console.WriteLine("What's your favorite Vodka \n 1. Ciroc \n 2. Titos \n 3. Bevidere");
            string liquid = Console.ReadLine();
            int.TryParse(liquid, out Liqlac);

            switch((Vodka)Liqlac)
            {
                case Vodka.Ciroc:
                    Ciroc();
                    break;
                case Vodka.Titos:
                    Titos();
                    break;
                case Vodka.Bevidere:
                    Bevidere();
                    break;
                default:
                    break;
            
            }
            Console.ReadKey();



        }
    }
}
