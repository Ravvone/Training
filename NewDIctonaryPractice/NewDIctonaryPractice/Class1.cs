using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDIctonaryPractice
{
    class Class1
    {

        public int TruckID { get; set; }
        public string TruckName { get; set; }
        public int TruckYear { get; set; }
        public string TruckType { get; set; }
        public string Cost { get; set; }

        public void PrintTruck()
        {

            Console.WriteLine($"{TruckName} {TruckID} is a Suv manufactured by {TruckType} in {TruckYear} and cost a wopping {Cost}");
            Console.ReadLine();

            
        }

        public void PrintTruck2()
        {
            Console.WriteLine("What is your favorite ?");
            string choice = Console.ReadLine().ToLower();

            if(choice == "bentayga")
            {
                Console.WriteLine("The Bentayga is a great choice for the elegant billionaires refined taste");

            }
            
            else if(choice == "g-Wagon" || choice == "gwagon")
            {
                Console.WriteLine("The G-Wagon is a luxgurious choice for the moderate businessman. But is quite rigid of a ride.");


            }
            else if(choice == "levante")
            {

                Console.WriteLine("This is a good choice manufactured by the Maserati Group. Very Affordable at 3 and 1/2 stars");
            }
            else
            {
                Console.WriteLine("Sorry, Please enter a Luxury Suv.");

                
            }
            
           

            Console.ReadLine();



            


        }

    }
}
