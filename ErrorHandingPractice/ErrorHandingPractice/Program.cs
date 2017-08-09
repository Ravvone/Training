using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsofGas;
            int mpg;
            //Program p = new Program();
            //p.StringError();



            try
            {
                Console.WriteLine("Enter miles driven");
                milesDriven = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter gallons of gas");
                gallonsofGas = Convert.ToInt16(Console.ReadLine());

                mpg = milesDriven / gallonsofGas;
                Console.WriteLine($"you are getting {mpg} miles per gallon");
                Console.ReadLine();
            }
            catch(Exception )
            {
                Console.WriteLine("Your code had an error");

            }
            Console.ReadLine();
        }
        public void StringError()
        {

            try
            {
                int x =100, y =0, done;
                done = x / y;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("we are inside the to string exception");


            }
            Console.WriteLine("Our code kept going!!!!");
            Console.ReadLine();
        }
    }
}
