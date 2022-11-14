using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GoingOnVacation
{
    internal class Program
    {
        /*
         * A tour operator offers package holidys in England, 
         * Spain, Italy, Portugal and France. 
         * The program you are given defines an array with those 
         * options and takes N number as input. 
         * Wrtie a program to output the package option with N
         * index. If the number is out of range, program should
         * output "Wronng number". Regardless of the option
         * results, the program should output "Goodbye" at the end. 
         * 
         * Sample input
         * 2
         * 
         * Sample output 
         * Italy
         * Goodbye
         * 
         */
        static void Main(string[] args)
        {
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(tours[choice]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Wrong number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
