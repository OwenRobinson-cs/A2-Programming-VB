using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CeaserCypher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Message =("oo ii ee aa bb cc ee");
            Message = Encrypt(Message, 15, 8);
            Console.WriteLine(Message);


            using (StreamWriter CurrentFile = new StreamWriter(@"CypherText.txt"))
            {
                CurrentFile.WriteLine(Message);
            }
            Console.WriteLine("Nessage Saved to file: CypherText");

             Console.WriteLine(Decrypt(Message, 15, 8));
            Console.ReadLine();
        }

        private static string Encrypt(string Plaintext, int ShiftKey1, int ShiftKey2)
        {
            char[] PlainTextArray = Plaintext.ToCharArray();
            int ASCii = 0;
            int KeyNum = 1;
            int ShiftKey;
            for (int i = 0; i < PlainTextArray.Length - 1; i++)
            {
                ASCii = (int)PlainTextArray[i];

                if (KeyNum == 1)
                {
                    ShiftKey = ShiftKey1;
                }
                else
                {
                    ShiftKey = ShiftKey2;
                }

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

                    if (KeyNum == 1)
                {
                    KeyNum = 2;
                }
                    else
                {
                    KeyNum = 1;
                }



            }

            return new string(PlainTextArray);
        }
            private static string Decrypt(string CipherText, int ShiftKey1, int ShiftKey2)
            {
             
                char[] PlainTextArray = CipherText.ToCharArray();
                int ASCii = 0;
            int ShiftKey;
            int KeyNum = 1;

            if (KeyNum == 1)
            {
                ShiftKey = ShiftKey1;
            }
            else
            {
                ShiftKey = ShiftKey2;
            }


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

                if (KeyNum == 1)
                {
                    KeyNum = 2;
                }
                else
                {
                    KeyNum = 1;
                }




            }

            return new string(PlainTextArray);
            } 
    }
}
