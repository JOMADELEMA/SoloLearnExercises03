using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DrawingApplication
{
    internal class Program
    {
        /*
         * You are creating a drawing application and currently 
         * have only 1 tool - a pencil. You want to add brush and spray
         * to the drwawing toolbar. 
         * 
         * The program you are given declares an IDraw interface with 
         * The StartDraw() method, and class Draw, which performs 
         * pencil drawing by implementing the IDrwa interface. It outputs 
         * "Using pencil". 
         * 
         * Complete the given Brush and Spray classes by 
         * - Inheriting them from class Draw
         * - Implementing the StartDraw() method for each tool, in order to output
         * 
         *"Using brush" for Brush 
         *"Using spray" for Spray
         *
         *
         */
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }

        public interface IDraw
        {
            void StartDraw();
        }

        class Draw : IDraw
        {
            public virtual void StartDraw()
            {
                Console.WriteLine("Using pencil");
            }
        }

        class Brush : Draw
        {
            public override void StartDraw()
            {
                Console.WriteLine("Using brush");
            }
        }

        class Spray : Draw
        {
            public override void StartDraw()
            {
                Console.WriteLine("Using spray");
            }
        }
    }
}
