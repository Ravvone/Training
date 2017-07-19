using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randNum = r.Next(1, 10);
            int guessNum;
            int Numofguesses = 1;

            Console.WriteLine("Guess a number between 1 and 10");
            string numGuess = Console.ReadLine();
            int.TryParse(numGuess, out guessNum);

            while(randNum!=guessNum)
            {
                Console.WriteLine($"You have the wrong number {numGuess}. \n Try again");
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out guessNum);

                Numofguesses++;

            }
            if (randNum==guessNum)
            {
                Console.WriteLine($"YOur guess of {guessNum} was correct \n you guessed {Numofguesses}");
            }
            else
            {
                Console.WriteLine($"your guess of {guessNum} was not correct ... \n you guessed again ");
                Numofguesses++;
            }
            
            Console.ReadKey();
        }
    }
}
