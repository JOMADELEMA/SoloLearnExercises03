using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WhereAreThePlanes
{
    internal class Program
    {
        /*
         * You are the airport administrator responsible for setting
         * flight statuses. 
         * At first the flight program was showing only "Registration" and 
         * "Closed" statuses, but we need to expand it to give more detailed 
         * information. 
         * Derive WayStatus class from Flight class and complete its. 
         * 
         * Constructor, to output "On the way"
         * Destructor, to output "Landed"
         * 
         * so that the program coreclty outputs all the statuses of the flight.
         */

        static void Main(string[] args)
        {
            WayStatus status = new WayStatus();
        }

        class Flight
        {
            public Flight()
            {
                Console.WriteLine("Registration");
            }
            ~Flight()
            {
                Console.WriteLine("Closed");
            }
        }

        class WayStatus : Flight
        {
            public WayStatus()
            {
                Console.WriteLine("On The way");
            }
            ~WayStatus()
            {
                Console.WriteLine("Landed");
            }
        }
    }
}
