using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_CoffeeTime
{
    internal class Program
    {
        /*
         * A coffee shop manager is running a promotion and wants to offer
         * a discount for coffee dringks. 
         * the program you are given takes the discount value as input and
         * defines a dictionary, where the names of the coffee drinks are 
         * set as keys, and their prices are set as values. 
         * Write a program to discount all of the prices and output a 
         * new price list in the format shown below. 
         * 
         * Sample input
         * 10
         * 
         * Sample output
         * Americano: 45
         * Latte: 63
         * Flat white:54 
         * Espress: 54
         * Cappuccino: 72
         * Mocha: 81
         * 
         */
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            string[] coffeeArr = coffee.Keys.ToArray();

            foreach (string drink in coffeeArr)
            {
                Console.WriteLine(drink + ": " + Math.Ceiling(coffee[drink] / (((float)discount + 100) / 100)));

            }


        }
    }
}
