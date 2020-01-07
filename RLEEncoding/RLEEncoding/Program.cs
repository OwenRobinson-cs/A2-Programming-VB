using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLEEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string CompressedData;
            Console.Write("Please Entre Phrase to be commpressed: ");
            userInput = Console.ReadLine();
            userInput = userInput + " ";
            CompressedData = DataCompressorinator(userInput);

            Console.WriteLine(CompressedData);
            Console.ReadKey();
        }

        static string DataCompressorinator(string userInput)
        {
            
            char prevChar;
            int numberofChars = 0;
            string CompressedMessage = "";


            prevChar = userInput[0];

            for (int i = 0; i < userInput.Length; i++)
            {
                
                if (userInput[i] == prevChar )
                {
                    numberofChars++;
                }
                else
                {
                    CompressedMessage = CompressedMessage + prevChar.ToString() + numberofChars.ToString();
                    prevChar = userInput[i];
                    numberofChars = 1;
                }
            }
            return CompressedMessage;
        }
    }
}
