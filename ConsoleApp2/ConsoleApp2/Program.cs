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
            int score;
            LoadQuestions();
            Console.Clear();
            Console.WriteLine("General knowladge multiple choice quiz");
            Console.WriteLine("______________________________________");
            Console.WriteLine("Press Any Key to begin the quiz");
            Console.ReadKey();
            PlayQuiz(out score);
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

        static void PlayQuiz(out int score)
        {
            int[] NumbersUsed = new int[10];
            int CurrentNumber = 0;
            score = 0;
            Random RNG = new Random(30);
            CurrentNumber = RNG.Next(30);
            char CorrectLetter;
            char UserInput;
            string unfilteredinput;
            //Ask Question
            for (int i = 0; i < 10; i++)
            {

                while (CurrentNumber == NumbersUsed[0] || CurrentNumber == NumbersUsed[1] || CurrentNumber == NumbersUsed[2] || CurrentNumber == NumbersUsed[3] || CurrentNumber == NumbersUsed[4] || CurrentNumber == NumbersUsed[5] || CurrentNumber == NumbersUsed[6] || CurrentNumber == NumbersUsed[7] || CurrentNumber == NumbersUsed[8]  || CurrentNumber == NumbersUsed[9] || CurrentNumber == 0)
                {
                    CurrentNumber = RNG.Next(30);
                }

                Console.WriteLine(Questions[CurrentNumber].Question);
                NumbersUsed[i] = CurrentNumber;
                //output all possible answers Randomly
                Random RNG1 = new Random(4);
                int AnswerOrder = RNG1.Next(4);
                if (AnswerOrder == 1)
                {
                    Console.WriteLine("A) " + Questions[CurrentNumber].Answer1);
                    Console.WriteLine("B) " + Questions[CurrentNumber].Answer2);
                    Console.WriteLine("C) " + Questions[CurrentNumber].Answer3);
                    Console.WriteLine("D) " + Questions[CurrentNumber].CorrectAnswer);
                    CorrectLetter = 'D';

                }
                else if (AnswerOrder == 2)
                {
                    Console.WriteLine("A) " + Questions[CurrentNumber].Answer3);
                    Console.WriteLine("B) " + Questions[CurrentNumber].CorrectAnswer);
                    Console.WriteLine("C) " + Questions[CurrentNumber].Answer2);
                    Console.WriteLine("D) " + Questions[CurrentNumber].Answer1);
                    CorrectLetter = 'B';
                }
                else if (AnswerOrder == 4)
                {

                    Console.WriteLine("A) " + Questions[CurrentNumber].Answer2);
                    Console.WriteLine("B) " + Questions[CurrentNumber].Answer1);
                    Console.WriteLine("C) " +Questions[CurrentNumber].CorrectAnswer);
                    Console.WriteLine("D) " +Questions[CurrentNumber].Answer3);
                    CorrectLetter = 'C';
                }
                else
                {
                    Console.WriteLine("A) " + Questions[CurrentNumber].CorrectAnswer);
                    Console.WriteLine("B) " + Questions[CurrentNumber].Answer3);
                    Console.WriteLine("C) " + Questions[CurrentNumber].Answer1);
                    Console.WriteLine("D) " + Questions[CurrentNumber].Answer2);
                    CorrectLetter = 'A';
                }

                //Get Answer 
                Console.Write("Please enter the letter next to the correct answer: ");
                unfilteredinput = Console.ReadLine().ToUpper();
                while (char.TryParse(unfilteredinput, out UserInput) = false)
                {

                }
            }
        }

    }
}
