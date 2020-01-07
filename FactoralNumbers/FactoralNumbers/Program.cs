using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoralNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int answer;

            Console.WriteLine("Enter Number: ");
            int.TryParse(Console.ReadLine(), out num);

            answer = num;

            for (int i = num - 1; i > 0; i--)
            {
                answer = answer * i;
            }

            Console.WriteLine(answer);
            Console.ReadKey();
        }



    }
}
