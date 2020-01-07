using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int answer;

            Console.WriteLine("Enter Number: ");
            int.TryParse(Console.ReadLine(), out num);

            answer = FactorialN(num); //Calls Function

            Console.WriteLine(answer); //Outputs answer
            Console.ReadKey();
        }

        static int FactorialN(int num)
        {
            int answer;
            if (num != 1)   //Checks to make sure input wasn't 1
            {
                answer = num * FactorialN(num - 1); //Calls itself while removing 1 from num
            }

            else
            {
                answer = 1; 
            }

            return answer;
        }
    }
}
