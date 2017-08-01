using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePractice3
{
    public class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Derived class
    public class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    public class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.Write("Sqrt of 35 (Integer) : " + Math.Sqrt(35));

            Square sq = new Square();

           

            Console.ReadKey();
        }
    }
    
}
