using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePractice3
{
    public class Square : Shape
    {
        protected double width, length;

        public void AcceptDetails( double l, double w)
        {
            length = 5;
            width = 7;



        }
        public double GetArea()
        {
            return length * width;

        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area:{0}", GetArea());



        }




    }
    public class Triangle : Shape
    {
        protected double length, width;
        public void AcceptDetails(double l, double w)
        {
            length = 2;
            width = 3;

        }
        public double GetArea()

        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area:{0}", GetArea());


        }



    }
    public class Octogon : Shape
    {
        double length, width;
        public void AcceptDetails(double l, double w)
        {
            length = 2;
            width = 3;


        }
        public double GetArea()

        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area:{0}", GetArea());



        }


    }
}
