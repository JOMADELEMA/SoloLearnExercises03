using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_QueueItUp
{
    internal class Program
    {
        /*
         * Write a program that will take 3 numbers as input and 
         * store them in a defined queue. 
         * 
         * Also add code to output the sorded sequence of elements
         * in the queue, separated by a space. 
         * 
         * sample input
         * 6
         * 3
         * 14
         * 
         * sample output
         * Queue: 6 3 14
         * Sorted: 3 6 14 
         * 
         */
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            while (q.Count < 3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();

            Console.Write("Sorted: ");

            int[] arr = q.ToArray();
            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
