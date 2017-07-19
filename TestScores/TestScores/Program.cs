using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int scoreNum;
            Console.WriteLine("Enter a number between 0 and 100");
            string skoo = Console.ReadLine();
            int.TryParse(skoo, out scoreNum);

            for ( scoreNum = 0; scoreNum< 10;  scoreNum++)
            {
                
            }




        }   
    }
}
