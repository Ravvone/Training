using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorApp
{
    class Student :Professor
    {

        public Student() :base (216,514)
        {
            Console.WriteLine("Things that make you go hmmmm");


        }
        public void Present()
        {

            Console.WriteLine("Yes it is Friday!!!");
        }









    }
}
