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

            answer = FactorialN(num);

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static int FactorialN(int num)
        {
            int answer;
            if (num == 1)
            {
                answer = 1;
            }
            else
            {
                answer = num * FactorialN(num - 1);
            }

            return answer;
        }
    }
}
