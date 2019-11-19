using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TeamNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TeamNames = new string[16];
            string fileName = @"TeamNames.txt";

            for (int i = 0; i < TeamNames.Length; i++)
            {
                Console.WriteLine("Enter Team name {0}", i + 1);
                TeamNames[i] = Console.ReadLine();
            }

            using (StreamWriter CurrentFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < TeamNames.Length; i++)
                {
                    CurrentFile.WriteLine(TeamNames[i]);
                }
            }

            Console.Clear();
            Console.WriteLine("File has been Created and Saved.");
            Console.ReadLine();
        }

    }
}
