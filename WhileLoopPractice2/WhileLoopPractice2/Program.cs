using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            int lowNum = 1000;
            int highNum = 2000;

            Console.WriteLine("Enter a valid Id Number between 1000 and 2000");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while(idNum<lowNum || idNum>highNum)
            {
                Console.WriteLine($"The ID number you entered {valNum} \n"
                    + $"must be between {lowNum} and {highNum} \n Try again..");
                 valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);



            }
            Console.WriteLine("The Id that you entered was valid");
            Console.ReadKey();
            
        }
    }
}
