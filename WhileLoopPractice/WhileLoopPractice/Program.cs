using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bob";
            string password = "007";


            Console.WriteLine("What is your username");
            string inputName = Console.ReadLine();
            while(inputName != userName)
            {
                Console.WriteLine($"The username that you entered was not correct");
                Console.WriteLine("Try again");
                Console.WriteLine("What is your username");
                inputName = Console.ReadLine();
                


            }


            Console.WriteLine("what is your password");
            string pw = Console.ReadLine();
            while (pw != password)
            {
                Console.WriteLine($"The password you entered is not correct");
                Console.WriteLine("Try Again");
                Console.WriteLine("what is your password");
                pw = Console.ReadLine();
            }


            Console.WriteLine("Welcome");
            Console.ReadKey();

                
        }
    }
}
