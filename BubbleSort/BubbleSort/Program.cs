using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSort
{
    class Program
    {
        public const int NumberofIntegers = 50000000;
        public const int Highestinteger = 100;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int[] Elephants = new int[NumberofIntegers];
            Random RNG = new Random();
            Console.WriteLine("The Bubble Sort Program \n \n \n");

            DateTime StartTime = DateTime.Now;

            GetNumbers(RNG, Elephants);
            Console.WriteLine("Task Completed");
            DateTime EndTime = DateTime.Now;

            TimeSpan TimeTaken = EndTime - StartTime;
            Console.WriteLine("Time taken = {0}ms", TimeTaken.TotalMilliseconds);
            //Console.WriteLine("Printing Numbers");

            //for (int i = 0; i < NumberofIntegers ; i++)
            //{
            //    Console.Write("{0}, ", Elephants[i]);
            //}
            //Console.WriteLine();
            StartTime = DateTime.Now;
            Console.WriteLine("Sorting Array");
            SortArray(Elephants);

            for (int i = 0; i < NumberofIntegers; i++)
            {
                Console.Write("{0}, ", Elephants[i]);
            }
            Console.WriteLine();

            EndTime = DateTime.Now;

            TimeTaken = EndTime - StartTime;
            Console.WriteLine("Time taken = {0}ms", TimeTaken.TotalMilliseconds);
            Console.ReadKey();
        }

        static void GetNumbers(Random RNG, int[] Elephants)
        {
           
            Console.WriteLine("Getting Randomised Numbers to fill array");

            for (int i = 0; i < NumberofIntegers; i++)
            {
                Elephants[i] = RNG.Next(Highestinteger + 1);
            }
        }

        static void SortArray(int[] Elephants)
        {
            for (int i = 0; i < NumberofIntegers - 1; i++)
            {
                for (int j = 0; j < NumberofIntegers - 1; j++)
                {
                    if (Elephants[j] > Elephants[j + 1])
                    {
                        int Temp = Elephants[j];
                        Elephants[j] = Elephants[j + 1];
                        Elephants[j + 1] = Temp;
                    }
                }
            }
        }
    }
}
