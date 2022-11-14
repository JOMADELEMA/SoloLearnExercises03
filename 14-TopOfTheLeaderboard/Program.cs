using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TopOfTheLeaderboard
{
    internal class Program
    {
        /*
         * You need to write a program for the game to sort player
         * scores. 
         * The program you are given takes N number as input, which 
         * represents the number of players, and defines a score list. 
         * Complete the program to take N count of numbers (the scores)
         * as input, stroe them in a scores list, sort and output them, 
         * each separated by a space. 
         * 
         * sample input
         * 3
         * 12
         * 4
         * 5
         * 
         * sample output
         * 4 5 12 
         */
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            List<int> scores = new List<int>();
            int count = 0;
            while (count<numOfPlayers)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
                count++;
            }

            scores.Sort();
            foreach(int score in scores)
            {
                Console.Write(score +" ");
            }
        }
    }
}
