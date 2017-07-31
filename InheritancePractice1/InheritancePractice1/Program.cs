using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;
        public double Salary;

        public void PrintFullName()
        {
            Console.WriteLine($"My first name is {FirstName} and my last name is {LastName} {EmployeeId}");
        }
        public void Salary5()
        {
            Console.WriteLine($"I make {Salary} a year");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.EmployeeId = 1001;
            ft.FirstName = "Mary";
            ft.LastName = "Mitchell";
            ft.Salary = 80000;
            ft.PrintFullName();
            ft.Salary5();

            Console.WriteLine("**************");

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.EmployeeId = 2001;
            pt.FirstName = "Peter";
            pt.LastName = "Parker";
            pt.Salary = 50000;
            pt.PrintFullName();
            pt.Salary5();


            Console.WriteLine("**********");

            SesonalWorker sw = new SesonalWorker();
            sw.EmployeeId = 3001;
            sw.FirstName = "Chris";
            sw.LastName = "Hamliton";
            sw.Salary = 30000;
            sw.PrintFullName();
            sw.Salary5();



            Console.WriteLine("**********");

            HR h = new HR();
            h.FirstName = "Ezzy";
            h.LastName = "Money";
            h.EmployeeId = 4001;
            h.Salary = 50000;
            h.PrintFullName();
            h.Salary5();



            Console.ReadLine();
           




        }


    }
    public class FullTimeEmployee : Employee
    {
        
        public double FullTImeId;
        public string Fulltime;


    }
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate;
        public int PartTimeId;
        public string Parttime;


    }
    public class SesonalWorker : FullTimeEmployee
    {

        public double HourlyRate;
        public int SeasonalId;
        public string Seasonal;

    }
    public class HR : SesonalWorker
    {


    }


       
       

        
    
}
