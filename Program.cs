using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "";
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            Console.Write("Enter the name of the file you wish to read: ");
            filename = Console.ReadLine();
            while (filename == "")
            {
                Console.WriteLine("Error: A filename needs to be entered, please try again.");
                Console.Write("Enter the name of the file you wish to read: ");
                filename = Console.ReadLine();
            }
             using (StreamReader CurrentFile
        }
    }
}
