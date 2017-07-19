using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEst_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double DblSumTotal = 0;
            double LIMIT = 0;
            int idNum;

            //Ask user to input 5 numbers to be added
         
            Console.WriteLine("Enter test scores 0 to 100 to be added together.");
            string input = Console.ReadLine();
            int.TryParse(input, out idNum);
            do
            {
                
                if (idNum==55 )
                {
                    Console.WriteLine("Error Message!!!");
                    
                }
                else
                {
                    DblSumTotal = DblSumTotal + idNum;
                    LIMIT = LIMIT + 1;
                }

            } while (LIMIT < 5);

            //Output total
            Console.WriteLine("The total sum of the 5 numbers is " + DblSumTotal);
            Console.ReadLine();
        }
    }
}
