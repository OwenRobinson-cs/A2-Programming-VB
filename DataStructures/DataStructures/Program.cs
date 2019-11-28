using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DataStructures
{
    class Program
    {
        public struct ClassInfo
        {
            public string FirstName;
            public string LastName;
            public string School;
            public int lastTestPercent;
            public char CurrentGrade;
        }
       public static ClassInfo[] Class = new ClassInfo[20];
      
        static void Main(string[] args)
        {
           
            GetInfo();
            //OutputInfo();
            Console.WriteLine("Prorgam Finsihed");
            SaveFile();
            Console.WriteLine("File Saved");
            LoadFile();
            Console.WriteLine("File Loaded");
            OutputInfo();
            Console.ReadKey();

        }

        static void GetInfo()
        {
            Console.WriteLine("Enter information for the class below:");

            for (int i = 0; i < Class.Length; i++)
            {
                Console.Write("Enter first name for Student {0}: ", i + 1);
                Class[i].FirstName = Console.ReadLine();

                Console.Write("Enter the Last name for Student {0}: ", i + 1);
                Class[i].LastName = Console.ReadLine();

                Console.Write("Enter Student {0}'s School: ", i + 1);
                Class[i].School = Console.ReadLine();

                Console.Write("Enter Student {0}'s last test percentage: ", i + 1);
                int.TryParse(Console.ReadLine(), out Class[i].lastTestPercent);

                Console.Write("Enter Student {0}'s Grade: ", i + 1);
                char.TryParse(Console.ReadLine(), out Class[i].CurrentGrade);
            }
        }

        static void OutputInfo()
        {
            Console.Clear();
            Console.WriteLine("You entered the following information: ");

            for (int i = 0; i < Class.Length; i++)
            {
                Console.WriteLine("Student {0}'s first Name: {1}", i + 1, Class[i].FirstName);

                Console.WriteLine("Student {0}'s last name: {1}", i + 1, Class[i].LastName);

                Console.WriteLine("Student {0}'s School: {1}", i + 1, Class[i].School);

                Console.WriteLine("Student {0}'s Last Test Percentage: {1}%", i + 1, Class[i].lastTestPercent);

                Console.WriteLine("Student {0}'s Current Grade: {1}", i + 1, Class[i].CurrentGrade);

                Console.WriteLine("Press Any Key to Continue to Next Student");
                Console.ReadKey();
            }
        }

        static void SaveFile()
        {

            using (FileStream stream = new FileStream("ClassInfo.dat", FileMode.Create))
            {
                using (BinaryWriter CurrentFile = new BinaryWriter(stream))
                {
                    for (int i = 0; i < Class.Length; i++)
                    {
                        CurrentFile.Write(Class[i].FirstName);

                        CurrentFile.Write(Class[i].LastName);

                        CurrentFile.Write(Class[i].School);

                        CurrentFile.Write(Class[i].lastTestPercent);

                        CurrentFile.Write(Class[i].CurrentGrade);
                    }
                }
            }
        }
        static void LoadFile()
        {

            using (FileStream stream = new FileStream("ClassInfo.dat", FileMode.Open))
            {
                using (BinaryReader CurrentFile = new BinaryReader(stream))
                {
                    for (int i = 0; i < Class.Length; i++)
                    {
                      Class[i].FirstName =  CurrentFile.ReadString();

                      Class[i].LastName = CurrentFile.ReadString();

                      Class[i].School = CurrentFile.ReadString();

                      Class[i].lastTestPercent = CurrentFile.ReadInt32();

                       Class[i].CurrentGrade = CurrentFile.ReadChar();
                    }
                }
            }

        }
    }
}
