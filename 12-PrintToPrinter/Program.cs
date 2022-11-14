using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PrintToPrinter
{
    internal class Program
    {
        /*
         * You are writing a program that can output the value of a 
         * variable of any type. It takes a string. an integer, and a double 
         * value as input and the it should output them. 
         * Create a generic method Print for a Printer class to execute the given
         * calls correctly. 
         * 
         * Sample input
         * Hello
         * 14
         * 7.6
         * 
         * Sample Output
         * Showing Hello
         * Showing 14
         * Showing 7.6
         * 
         */
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());

            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }

        class Printer
        {
            public static void Print<T>(T input)
            {
                Console.WriteLine($"Showing {input}");
            }
        }
    }
}
