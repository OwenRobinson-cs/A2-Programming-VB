using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCypher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Message =("Cheese Please!");
            Message = Encrypt(Message, 15);
            Console.WriteLine(Message);
            
            Console.WriteLine(Decrypt(Message, 15));
            Console.ReadLine();
        }

        private static string Encrypt(string Plaintext, int ShiftKey)
        {
            string ciphertext = "";
            char[] PlainTextArray = Plaintext.ToCharArray();
            int ASCii = 0;

            for (int i = 0; i < PlainTextArray.Length - 1; i++)
            {
                ASCii = (int)PlainTextArray[i];

                if (Char.IsUpper(PlainTextArray[i]))
                {
                    ASCii = ASCii - 65;
                    ASCii = ASCii + ShiftKey;
                    ASCii = ASCii % 26;
                    ASCii = ASCii + 65;
                    PlainTextArray[i] = (char)ASCii;
                }
                else if (Char.IsLower(PlainTextArray[i]))
                {
                    ASCii = ASCii - 97;
                    ASCii = ASCii + ShiftKey;
                    ASCii = ASCii + 26;
                    ASCii = ASCii % 26;
                    ASCii = ASCii + 97;
                    PlainTextArray[i] = (char)ASCii;
                }


            }

            return new string(PlainTextArray);
        }
            private static string Decrypt(string CipherText, int ShiftKey)
            {
             
                char[] PlainTextArray = CipherText.ToCharArray();
                int ASCii = 0;

                for (int i = 0; i < PlainTextArray.Length - 1; i++)
                {
                    ASCii = (int)PlainTextArray[i];


                if (Char.IsUpper(PlainTextArray[i]))
                    {
                        ASCii = ASCii - 65;
                        ASCii = ASCii - ShiftKey;
                    ASCii = ASCii + 26;
                        ASCii = ASCii % 26;
                        ASCii = ASCii + 65;
                        PlainTextArray[i] = (char)ASCii;
                    }
                    else if (Char.IsLower(PlainTextArray[i]))
                    {
                        ASCii = ASCii - 97;
                        ASCii = ASCii - ShiftKey;
                        ASCii = ASCii + 26;
                        ASCii = ASCii % 26;
                        ASCii = ASCii + 97;
                        PlainTextArray[i] = (char)ASCii;
                    }
               


                }

                return new string(PlainTextArray);
            } 
    }
}
