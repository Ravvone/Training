using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoes sh = new Shoes();
            sh.Make = "Jordan";
            sh.Model = "air seven";
            sh.Color = "black";
            sh.ID = 554555;
            sh.MyVar = "leather";
            sh.likeem = true;

            Shoes sl = new Shoes();
            sl.Make = "adidas";
            sl.Model = "shell toes";
            sl.Color = "black";
            sl.ID =554777;
            sl.MyVar = "suede";
            sl.likeem = false;

            List<Shoes> kicksList = new List<Shoes>();

            kicksList.Add(sh);
            kicksList.Add(sl);

            

            foreach (Shoes item in kicksList)
            {
                if(item.likeem != true)
                {
                    Console.WriteLine($"{item.Make} {item.Model} is a type of kick and I dont like these kicks.");

                }
                else
                {

                    Console.WriteLine($"{item.Make} {item.Model} is a type of kick and I Like these kick.");
                }

               

            }
            Console.ReadLine();





        }
    }
}
