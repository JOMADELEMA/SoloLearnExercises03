using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Accelerate
{
    internal class Program
    {
        /*
         * A racing videogame has 3 difficulty levels: Easy, 
         * Medium, and hard. 
         * Each difficulty level is assigned maximum time to 
         * complete the track: the higher the difficulty, the 
         * lower the time. 
         * The program you are given defines Payer class and Difficulty 
         * enum, and creates 3 Player objects with different difficulties 
         * as parameter for the constructor. 
         * 
         * Complete the Player constructor, which takes the enum
         * as a parameter to check the time for each difficulty 
         * optin and outputs the corresponding message:
         * 
         * Easy: "You have 3 minutes 45 seconds"
         * Medium: "You have 3 minutes 20 seconds"
         * Hard: "You have 3 minutes"
         */
        static void Main(string[] args)
        {
            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }

        class Player
        {
            public Player(Difficulty x)
            {
                switch (x)
                {
                    case Difficulty.Easy:
                        Console.WriteLine("You have 3 minutes 45 seconds");
                        break;
                    case Difficulty.Medium:
                        Console.WriteLine("You have 3 minutes 20 seconds");
                        break;
                    case Difficulty.Hard:
                        Console.WriteLine("You have 3 minutes");
                        break;
                }
            }
        }

        enum Difficulty
        {
            Easy, 
            Medium,
            Hard
        }
    }
}
