using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordArray = { "Bob", "John", "James", "Janet", "Karen", "Tedd", "Steve", "Richard", "Kathy", "winnner", "makeup", "face", "velvet", "discrimination", "cope", "mystery", "waiter", "hurt", "coerce"};
            Console.WriteLine("Merge Sort Words: \n \n");

            Console.WriteLine("Unsorted Words: ");
            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.Write(wordArray[i] + ", ");
            }
            Console.WriteLine();

            MergeSort(wordArray, 0, wordArray.Length - 1);

            Console.WriteLine("Sorted Words: ");
            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.Write(wordArray[i] + ", ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }


        static public void MergeSort(string[] words, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(words, left, mid); //recursive call 1
                MergeSort(words, (mid + 1), right); //recursive call 2

                DoMerge(words, left, (mid + 1), right);
            }
        }

        static public void DoMerge(string[] words, int left, int mid, int right)
        {
            string[] temp = new string[words.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (words[left].CompareTo(words[mid]) < 1)
                    temp[tmp_pos++] = words[left++];
                else
                    temp[tmp_pos++] = words[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = words[left++];

            while (mid <= right)
                temp[tmp_pos++] = words[mid++];

            for (i = 0; i < num_elements; i++)
            {
                words[right] = temp[right];
                Console.Write(words[right].ToString().PadLeft(3)); //delete me
                right--;
            }
            Console.WriteLine();
        }

    }
}
