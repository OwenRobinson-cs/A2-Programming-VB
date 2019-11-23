using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingandWritingFilesHWQuizConsoleapp
{
    class Program
    {
        static string[,] Questions = new string[10, 2];
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            //Declare Variables
            int Selection;
            string input;
            

            //Output menu
            Console.WriteLine("Menu");
            Console.WriteLine("Enter the Corresponding Number for the option you wish to chose: ");
            Console.WriteLine("1) Load Questions \n2) Write New Questions \n3) Take the Quiz \n4) Exit Program");
            input = Console.ReadLine();

            //Validation Check
            while (int.TryParse(input, out Selection) == false || int.Parse(input) > 5 || int.Parse(input) < 1)
            {
                Console.Write("Error, value entered is not recognised. Please try again: ");
                input = Console.ReadLine();
            }

            //Call Appropriate Subroutine 
            if (Selection == 1)
            {
                Console.WriteLine("Selection Chosen: Load Questions");
                PressAnyKey();
                Console.Clear();
                LoadQuestions();
            }
            else if (Selection == 2)
            {
                Console.WriteLine("Selection Chosen: Write New Questions ");
                PressAnyKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                WriteQuestions();
            }
            else if (Selection == 3)
            {
                Console.WriteLine("Selection Chosen: Take the Quiz");
                PressAnyKey();
                Console.Clear();
                PlayQuiz(Questions);
            }
            else
            {
                Console.WriteLine("Selection Chosen: Exit Program");
                PressAnyKey();
            }
        }

        static void LoadQuestions()
        {
            Console.WriteLine("Load Questions \n");

            //Declare Variables 
            string fileName;


            //Get File Name
            Console.WriteLine("Enter the File Name or File Path (Case Sensitive):");
            fileName = @Console.ReadLine();

            //Find File && load into array 
            try
            {
                using (StreamReader CurrentFile = new StreamReader(fileName))
                {
                    CurrentFile.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        Questions[i, 0] = CurrentFile.ReadLine();
                    }
                    CurrentFile.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        Questions[i, 1] = CurrentFile.ReadLine();
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Questions[i, 0]);
                }
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine(Questions[x, 1]);
                }
                Console.WriteLine("File Loaded Successfully.");
                PressAnyKey();
                Console.Clear();
                Menu();

            } catch (FileNotFoundException error)
            {
                int input;
                Console.WriteLine("Could not find File. Press 1 for full error output, press any other key to close the program.");
                int.TryParse(Console.ReadLine(), out input);

                if (input == 1)
                {
                    Console.WriteLine(error);
                    PressAnyKey();
                }
                else
                {
                    Console.Clear();
                    PressAnyKey();
                }

            }
            
        }

        static void WriteQuestions()
        {
            Console.WriteLine("Write Questions");

            //Declare Variables
            string fileName;

            //create a file name 
            Console.Write("Enter a File Name (Name cannot include any special characters): ");
            fileName = Console.ReadLine() + ".txt";

            //Create Questions 

            //Input Questions
            Console.WriteLine("Questions: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Question {0}", i + 1);
                Questions[i, 0] = Console.ReadLine();
            }

            //Input Answers
            Console.WriteLine("Answers: (will be saved as all lowercase)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the Answer for Question {0}", i + 1);
                Questions[i, 1] = Console.ReadLine().ToLower();
            }

            //Save Questions && Answers to File

            using (StreamWriter CurrentFile = new StreamWriter(fileName))
            {
                CurrentFile.WriteLine("Questions: ");
                for (int i = 0; i < 10; i++)
                {
                    CurrentFile.WriteLine(Questions[i, 0]);
                }
                CurrentFile.WriteLine("Answers: ");
                for (int i = 0; i < 10; i++)
                {
                    CurrentFile.WriteLine(Questions[i, 1]);
                }
            }               
            //Output Complete

            Console.WriteLine("Questions saved to file {0} and loaded into Memory.", fileName);
            PressAnyKey();
            Console.Clear();
            Menu();
        }

        static void PlayQuiz(string[,] Questions)
        {

            
            Console.WriteLine("Play Quiz \n");

            //Show Questions
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Questions[i, 0]);
            }

            //Declare Variables
            int Score = 0;
            string name;
            string userAnswer;

            //Enter Name
            Console.Write("Enter your Name:");
            name = Console.ReadLine();



            //Play Quiz

            Console.WriteLine("Press Any Key to Begin");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                //Ask Question
                Console.WriteLine(" {0}) {1}", i + 1, Questions[i, 0]);
                //Get && Compare Answer
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == Questions[i, 1])
                {
                    Console.WriteLine("Correct");
                    Score++;
                    Console.WriteLine("Press any key to continue to the next question.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect, the Answer was: {0}", Questions[i, 1]);
                    Console.WriteLine("Press any key to continue to the next question.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            //Display results
            Console.WriteLine("Score for {0} was: {1}", name, Score);

            PressAnyKey();
            Console.Clear();
            Menu();
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press Any Key to Contine...");
            Console.ReadKey();
        }
    }
}
