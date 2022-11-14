using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_FunWithDimensions
{
    internal class Program
    {
        /*
         * A cuboid is a three-dimensional shape with a length, 
         * width, and height.
         * 
         * The program you are given takes shose dimensions
         * as inputs, defines Cuboid struct and creates
         * this object. 
         * Complete the program by creating a constructor, which will 
         * take the lenght, the width, and the heigth as parameters
         * and assign them to its struct members. 
         * Also complete Volume() and Perimeter() methods inside
         * the struct, to calculate and return them, so that the
         * given methods calls work correctly. 
         * 
         * sample input
         * 5
         * 4
         * 5
         * 
         * Sample output
         * Volume 100
         * Perimeter 56
         *
         * volume = length * width * height
         * perimeter = 4 * (length + width + height)
         */

        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);
            
            Console.WriteLine($"Volume: {cuboid.Volume()}");
            Console.WriteLine($"Perimeter: {cuboid.Perimeter()}");
        }

        struct Cuboid
        {
            public int length;
            public int width;
            public int height;

            public Cuboid(int length, int width, int height)
            {
                this.length = length;
                this.width = width;
                this.height = height;
            }

            public int Volume()
            {
                return length * width * height;
            }

            public int Perimeter()
            {
                return 4 * (length + width + height);
            }
        }
    }
}
