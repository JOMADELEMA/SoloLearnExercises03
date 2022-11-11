using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PerimeterCalculator
{
    internal class Program
    {
        /*
         * The program you are given defines abstract class Figure
         * and derives REctangle and Triangle classses form it. 
         * Add an abstract method perimeter to class Figure, than 
         * override it in derived classes to calculate perimeters of 
         * already created Rectangle and Triangle objects. 
         * 
         * Hint
         * Perimeter of rectangle with width w and height h = 2*w+2*h
         * Perimeter of triangle with sides s1, s2, s3 = s1+s2+s3.
         */
        static void Main(string[] args)
        {
            Figure rectangle = new Rectangle(5, 6);
            Figure triangle = new Triangle(4, 8, 3);

            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(triangle.Perimeter());

        }

        abstract class Figure
        { 
            public abstract int Perimeter();
        }

        class Rectangle : Figure
        {
            public int width;
            public int height;
            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public override int Perimeter()
            {
                return width * 2 + height * 2;
            }
        }

        class Triangle : Figure
        {
            public int side1;
            public int side2;
            public int side3;

            public Triangle(int side1, int side2, int side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            public override int Perimeter()
            {
                return side1 + side2 + side3;
            }
        }

    }
}
