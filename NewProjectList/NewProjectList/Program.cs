using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProjectList
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile a1 = new Automobile();

            a1.AutoID = 1000;
            a1.Make = "McLauren";
            a1.Model = "s570";
            a1.Year = 2017;
            a1.Color = "tangerine";

            Automobile a2 = new Automobile();

            a2.AutoID = 2000;
            a2.Make = "Mercedes";
            a2.Model = "Maybach";
            a2.Year = 2017;
            a2.Color = "black";

            List<Automobile> carList = new List<Automobile>();

            carList.Add(a1);
            carList.Add(a2);

            foreach (Automobile item in carList)
            {
                Console.WriteLine($"Our model is {item.Model}, made by {item.Make}.");

            }
            

            Console.ReadLine();
            

        }
    }
}
