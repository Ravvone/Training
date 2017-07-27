using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string favorite1 = "Lasagne";
            string favorite2 = "Hamburgers";

            int favoriteNum1 = 500;
            int favoriteNum2 = 500;

            int ourFavoriteNum = FavoriteNumbers(favoriteNum1, favoriteNum2);
            string ourFavorite = FavoriteFood(favorite1, favorite2);

            Console.WriteLine($"Our favorite foods are {favorite1} and {favorite2} put together these are {ourFavorite}");
            Console.ReadLine();
            Console.WriteLine($"Our favorrite numbers are {favoriteNum1} and {favoriteNum2} put together these are {ourFavoriteNum}");
        }
        private static string FavoriteFood(string food1, string food2)
        {
            string bestFood = food1 + food2;

            return bestFood;
        }
        private static int FavoriteNumbers(int Number1, int Numbe2)
        {
            int favnumber = Number1 + Numbe2;

            return favnumber;
        }
    }
}
