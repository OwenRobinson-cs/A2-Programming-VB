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
            while (int.TryParse(input, out Selection) == false || int.Parse(Console.ReadLine()) > 5 || int.Parse(Console.ReadLine()) < 1);
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
                PlayQuiz();
            }
            else
            {
                Console.WriteLine("Selection Chosen: Exit Program");
                PressAnyKey();
            }
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press Any Key to Contine...");
            Console.ReadKey();
        }
    }
}
