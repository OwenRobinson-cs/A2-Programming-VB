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
        public static int NumberofIntegers = 50000000;
        static void Main(string[] args)
        {
            
            int[] Elephants = new int[NumberofIntegers];
            Random RNG = new Random();
            Console.WriteLine("The Bubble Sort Program \n \n \n");

            DateTime StartTime = DateTime.Now;

            GetNumbers(RNG, Elephants);
            Console.WriteLine("Task Completed");
            Console.WriteLine("Printing Numbers");

            for (int i = 0; i < NumberofIntegers ; i++)
            {
                Console.Write("{0}, ", Elephants[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Sorting Array");
            SortArray(Elephants);

            for (int i = 0; i < NumberofIntegers; i++)
            {
                Console.Write("{0}, ", Elephants[i]);
            }
            Console.WriteLine();

            DateTime EndTime = DateTime.Now;

            TimeSpan TimeTaken = EndTime - StartTime;
            Console.WriteLine("Time taken = {0}ms", TimeTaken.TotalMilliseconds);
            Console.ReadKey();
        }

        static void GetNumbers(Random RNG, int[] Elephants)
        {
           
            Console.WriteLine("Getting Randomised Numbers to fill array");

            for (int i = 0; i < NumberofIntegers; i++)
            {
                Elephants[i] = RNG.Next(51);
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
