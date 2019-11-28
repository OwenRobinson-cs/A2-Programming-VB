using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        public struct Questionstruct
        {
            public string Question;
            public string Answer1;
            public string Answer2;
            public string Answer3;
            public string CorrectAnswer;
        }
        public static Questionstruct[] Questions = new Questionstruct[30];

        static void Main(string[] args)
        {
            LoadQuestions();
            Console.ReadKey();
        }

        static void LoadQuestions()
        {
            string fileName = @"Questions.txt";
        
            using (StreamReader CurrentFile = new StreamReader(fileName))
            {
                try
                {
                    for (int i = 0; i < 30; i++)
                    {

                        Questions[i].Question = CurrentFile.ReadLine().ToString();
                        Questions[i].Answer1 = CurrentFile.ReadLine().ToString();
                        Questions[i].Answer2 = CurrentFile.ReadLine().ToString();
                        Questions[i].Answer3 = CurrentFile.ReadLine().ToString();
                        Questions[i].CorrectAnswer = CurrentFile.ReadLine().ToString();
                        
                    }
                    Console.WriteLine("Questions Successfully Loaded");
                }
                catch
                {
                    Console.WriteLine("An Error Occured, Please Restart the Program...");
                }
            }
        }
    }
}
