using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dish ="";
            double date =0;
            double month =0;

            double birthdate = Bday(date, month);
            string grub = Food(dish);
            Console.WriteLine($"Your birtdate is {birthdate}");
            Console.WriteLine($"Your favorite dish is {grub}")







        }
        public static string Food(string food1)
        {
            Console.WriteLine("What is your favorite food");
            string grub = Console.ReadLine();
            return grub;
        }
        public static double Bday(double number1, double number2)
        {
            Console.WriteLine("What is your birth date /dd ?");
            string input = Console.ReadLine();
            double.TryParse(input, out number1);
            Console.WriteLine("What month were you born /mm ?");
            string input2 = Console.ReadLine();
            double.TryParse(input2, out number2);
            double birthdate = number1 + number2;
            
            return birthdate;
        }
    }
}
