using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {

           public static void Main(string[] args)
            {
                int[] NumberArray = { 77, 5, 3, 78, 9, 90, 34, 36, 500, 79, 1, 7, 66, 21, 92, 455, 46 };
                int searchNo;

                Console.Write("What number do you want to find: ");
                int.TryParse(Console.ReadLine(), out searchNo);

                Console.WriteLine(LinearSearch(NumberArray, searchNo));
                Console.ReadKey();
            }

            public static int LinearSearch(int[] inputArray, int key)
            {
                int location = 0;
                bool found = false;
                for (int i = 0; i < inputArray.Length; i++)
                {
                        if (key == inputArray[i])
                        {
                               Console.WriteLine("Number Found");
                               location = i;
                               found = true;
                               break;

                        }
                }

                        if (found != true)
                        {
                       Console.WriteLine("Number not found.");
                        }

                     return location;
            }

       
    }
}
