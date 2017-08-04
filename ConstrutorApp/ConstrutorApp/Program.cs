using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor pr = new Professor("Charles", "Xavier");
            pr.GoodPeople();
            Professor rp = new Professor(216, 514);
            rp.ShowNumbers();
            Console.ReadLine();


        }
        public static string Smash()
        {
            string anger = "Hulk Smash";
            return anger;
        }
    }
}
