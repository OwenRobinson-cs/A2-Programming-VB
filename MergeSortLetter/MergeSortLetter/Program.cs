using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLetter
{
    class Program
    {
        public const int AmountofData = 1000000;
        static void Main(string[] args)
        {
            char[] UnsortedArray = new char[AmountofData];
            UnsortedArray = FillArray();

            Console.WriteLine("Merge Sort \n \n");

            Console.WriteLine("Unsorted Letters: ");

            for (int i = 0; i < AmountofData; i++)
            {
                Console.Write("{0}, ", UnsortedArray[i]);
            }
            Console.WriteLine("\n \n");

            DateTime StartTime = DateTime.Now;
            MergeSort(UnsortedArray, 0, UnsortedArray.Length - 1);
            DateTime EndTime = DateTime.Now;
            TimeSpan TimeTaken = EndTime - StartTime;

            Console.WriteLine("Sorted Letters: ");

            for (int i = 0; i < AmountofData; i++)
            {
                Console.Write("{0}, ", UnsortedArray[i]);
            }
            Console.WriteLine("\n \n");

            Console.WriteLine("The Program took {0}ms to execute", TimeTaken.TotalMilliseconds);
            Console.ReadKey();
        }

        static char[] FillArray()
        {
            char[] TempArray = new char[AmountofData];
            Random RNG = new Random();
            for (int i = 0; i < AmountofData; i++)
            {
                TempArray[i] = (Char)('a' + RNG.Next(0, 26));
            }

            return TempArray;
        }


        static public void MergeSort(char[] letters, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(letters, left, mid); //recursive call 1
                MergeSort(letters, (mid + 1), right); //recursive call 2

                DoMerge(letters, left, (mid + 1), right);
            }
        }

        static public void DoMerge(char[] letters, int left, int mid, int right)
        {
            char[] temp = new char[letters.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (letters[left] <= letters[mid])
                    temp[tmp_pos++] = letters[left++];
                else
                    temp[tmp_pos++] = letters[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = letters[left++];

            while (mid <= right)
                temp[tmp_pos++] = letters[mid++];

            for (i = 0; i < num_elements; i++)
            {
                letters[right] = temp[right];
                //Console.Write(letters[right].ToString().PadLeft(3)); //delete me
                right--;
            }
            //  Console.WriteLine();
        }

    }

}

