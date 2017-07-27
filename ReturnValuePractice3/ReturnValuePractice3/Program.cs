using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            string str1 = "Eric";
            string str2 = "Ravvone";
            string str3 = "Freeman";

            int all = Addition(num1, num2, num3);
            int allx = Multiply(num1, num2, num3);

            string ezzy =MyName(str1, str2, str3);


            Console.WriteLine($"My name is {ezzy}, I can add.\nFor example 1+2+3 = {all}.\nI can do multiplication too.\n like 1*2*3 = {allx}. ");
            Console.ReadLine();


        }
        private static int Addition(int Numb1, int Numb2, int Numb3)
        {
            int sum = Numb1 + Numb2 + Numb3;
            return sum;

        }
        private static int Multiply(int numb1, int numb2, int numb3)
        {
            int product = numb1 * numb2 * numb3;
            return product;

        }
        private static string MyName(string aa, string bb, string cc)
        {
            string Eroc = aa + " " + bb + " " + cc;
            return Eroc;
        }
    }
}
