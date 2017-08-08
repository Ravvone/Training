using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDIctonaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 truck1 = new Class1();
            truck1.TruckID = 0001;
            truck1.TruckName = "Bentayga";
            truck1.TruckType = "Bentley";
            truck1.TruckYear = 2017;
            truck1.Cost = "$230,000";

            Class1 truck2 = new Class1();
            truck2.TruckID = 0002;
            truck2.TruckName = "G-Wagon";
            truck2.TruckType = "Mercedes";
            truck2.TruckYear = 2017;
            truck2.Cost = "$122,400";

            Class1 truck3 = new Class1();
            truck3.TruckID = 0003;
            truck3.TruckName = "Levante";
            truck3.TruckType = "Maserati";
            truck3.TruckYear = 2017;
            truck3.Cost = "$72,600";

            Dictionary<int, Class1> SUV = new Dictionary<int, Class1>();
            SUV.Add(truck1.TruckID, truck1);
            SUV.Add(truck2.TruckID, truck2);
            SUV.Add(truck3.TruckID, truck3);

           

            foreach (KeyValuePair<int,Class1> item in SUV)
            {
                Class1 cs = item.Value;
                cs.PrintTruck();

            }

            Class1 sc = new Class1();
            sc.PrintTruck2();
            Console.ReadLine();
           
















        }
    }
}
