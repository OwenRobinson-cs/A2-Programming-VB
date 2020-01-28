using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {

        public const int AmountofData = 5000000;
        static void Main(string[] args)
        {
            int[] NumberArray = new int[AmountofData];
            NumberArray = FillArray();

            Console.WriteLine("Merge Sort \n \n");

            //Console.WriteLine("Unsorted Numbers: ");

            //for (int i = 0; i < AmountofData; i++)
            //{
            //    Console.Write("{0}, ", NumberArray[i]);
            //}
            //Console.WriteLine("\n \n");

            DateTime StartTime = DateTime.Now;
            MergeSort(NumberArray, 0, NumberArray.Length -1);
            DateTime EndTime = DateTime.Now;
            TimeSpan TimeTaken = EndTime - StartTime;

            Console.WriteLine("Sorted Numbers: ");
            for (int i = 0; i < AmountofData; i++)
            {
                Console.Write("{0}, ", NumberArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The Program took {0}ms to execute", TimeTaken.TotalMilliseconds);
            Console.ReadKey();
        }

        static int[] FillArray()
        {
            int[] TempArray = new int[AmountofData];
            Random RNG = new Random();
            for (int i = 0; i < AmountofData; i++)
            {
                TempArray[i] = RNG.Next(1, 51);
            }

            return TempArray;
        }


        static public void MergeSort(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid); //recursive call 1
                MergeSort(numbers, (mid + 1), right); //recursive call 2

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                //Console.Write(numbers[right].ToString().PadLeft(3)); //delete me
                right--;
            }
            //Console.WriteLine();
        }

    }
}
