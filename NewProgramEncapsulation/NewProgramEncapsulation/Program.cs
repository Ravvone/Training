using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProgramEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ee = new Employee();
            Program p = new Program();
            ee.FirstName = "Young";
            ee.Lastname = "Hoe";
            ee.IdNumber = 5000;
            ee.SocNumber = 5552300;
            ee.Tuition = 500;
            p.DisplayName(ee);
            Console.ReadLine();
        }
        public void DisplayName(Employee emp)
        {
            Console.WriteLine($"My first name is  {emp.FirstName}.\n My last name is {emp.Lastname}\n my ID number is {emp.IdNumber} and my Soc Number is {emp.SocNumber}.  ");
        }
    }
}
