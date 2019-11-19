using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Countries = new string[20];
            string fileName = @"countries.txt";

            using (StreamReader CurrentFile = new StreamReader(fileName))
            {
                for (int i = 0; i < 20; i++)
                {
                    Countries[i] = CurrentFile.ReadLine();
                }
            }
            OutPutCountries(Countries);

            Console.ReadLine();
        }

        static string OutPutCountries(string[] Countries)
        {
           

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Countries[i]);
            }

            return "done";
        }


    }
}
