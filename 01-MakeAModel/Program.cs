using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MakeAModel
{
    internal class Program
    {
        /*
         * The program you are given takes the brand and model
         * of the car as input, and defines a Vehicle class with 
         * model property and ShowModel() method. Complete the 
         * Car class to inherit the Vehicle class, and add the Model 
         * property and ShowModel() method so that the gien method 
         * call of the car object works correctly (see sample output).
         * 
         * Sample input
         * BMW 
         * 5 Series
         * 
         * Sample output
         * Brand: BMW
         * Model: 5 Series
         */
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
        }

        class Vehicle
        {
            public string Brand { get; set; }
            public void ShowBrand()
            {
                Console.WriteLine("Brand: " + Brand);
            }
        }

        class Car : Vehicle
        {
            public string Model { get; set; }

            public void ShowModel()
            {
                Console.WriteLine("Model: " + Model);
            }
        }
    }
}
