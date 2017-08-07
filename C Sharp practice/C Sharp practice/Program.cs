using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Breakfast special = new Breakfast("French toast", 4.99);
            
            //Display the info about breakfast
            Console.WriteLine(special.INFO);
            // then display today's special
            Console.WriteLine("Today we are having {0} for {1}",special.Name, special.Price.ToString("C2"));
            Console.ReadLine(); 


        }
       
    }
   
    class Breakfast
    {
        public string INFO = "Breakfast is the most important meal of the day.";
        private string name;
        private double price;
        public Breakfast(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }


    }
}
