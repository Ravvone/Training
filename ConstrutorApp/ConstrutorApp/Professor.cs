using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorApp
{
    class Professor
    {
        string fname;
        string lname;

        string important1;
        string important2;

        public Professor(string Fname, string Lname)
        {
            fname = Fname;
            lname = Lname;

        }
        public Professor (string Code1, string  Code2)
        {
            important1 = Code1;
            important2 = Code2;


        }

        public void GoodPeople()
        {
            Console.WriteLine($"My first name is {fname} and my last name is {lname}");

        }
        public void ShowNumbers()
        {

            Console.WriteLine($"My secret number{important1} and {important2}");
        }


    }
}
