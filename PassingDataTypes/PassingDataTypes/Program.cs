using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Eric", "Eroc", "Young E", "Ravvone", "Zaddy" };
            int[] arrayInt = { 1, 5, 12, 66, 27 };
            for (int i = 0; i < arrayInt.Length; ++i)
            {
                Console.WriteLine("The value of the Arrayint array is " + arrayInt[i]);
            }
            Console.WriteLine("we are now out of the loop");
            Console.ReadLine();
            AddArray(arrayInt);
            Console.ReadLine();
            SumArray(arrayInt);
            Console.ReadLine();
            Something(arrayInt);
            Console.ReadLine();
            Strings(names);
        }
        public static void SumArray(int [] arrayVals )
        {
            int sort = arrayVals.Sum();
            Console.WriteLine($"The sum of all the values is {sort}");
        }
        public static void AddArray(int [] AddArray)
        {
            int maxVal = AddArray.Max();
            Console.WriteLine($"The maximum valkue of the array is {maxVal}");
            Console.ReadLine();
        }
        public static void Something(int [] somethingarray)
        {
            int some = somethingarray.Count();
            Console.WriteLine($"The count of the array is {some}");
            Console.ReadLine();
        }
        public static void Strings(string [] namearray)
        {
            for (int k =0; k < namearray.Length;k++)
            {
                Console.WriteLine("The names of the Array are " + namearray[k]);

            }
            Console.ReadLine();
        }
    }
}
