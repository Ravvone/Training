using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Student st = new Student();
            Student s1 = new Student();
            Student s2 = new Student();





            st.IdNumber = 281338004;
            st.FirstName = "Mike";
            st.LastName = "Jones";

            s1.IdNumber = 218330216;
            s1.FirstName = "Luda";
            s1.LastName = "Chris";

            s2.IdNumber = 216555095;
            s2.FirstName = "Young";
            s2.LastName = "Ezzy";
            p.ShowStudent(st);
            p.ShowStudent(s1);
            p.ShowStudent(s2);




        }
        public void ShowStudent(Student scholar)
        {
            Console.WriteLine($"My Id number is {scholar.IdNumber} and my name is {scholar.FirstName} {scholar.LastName}");
            Console.ReadLine();
        }
    }
}
