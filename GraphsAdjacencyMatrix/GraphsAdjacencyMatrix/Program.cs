using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAdjacencyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string Location1 = null;
            int Location1int;
            string Location2 = null;
            int Location2int;
            bool loop = true;
            bool error = false;
            char userAnswer;
            int[,] Matrix = new int[6, 6];

            FillMatrix(ref Matrix);

            while (loop == true)
            {
                GetLocations(ref Matrix, ref Location1, ref Location2);

                Location1int = Changetoint32(Location1);
                if (Location1int == 666) //Error Validation for Location 1
                {
                    Console.WriteLine("An Error Occured with Location 1. The program will close");
                    error = true;
                }

                Location2int = Changetoint32(Location2);
                if (Location2int == 666) //Error Validation for Location 2
                {
                    Console.WriteLine("An Error Occured with Location 2, The program will close.");
                    error = true;
                }

                if (error == false)
                {
                    OutputConnectionandDistance(ref Matrix, Location1int, Location2int, Location1, Location2);
                }
                Console.ReadLine();

                Console.WriteLine("Do you Wish to Query 2 other locations? (Y/N)"); //Add an Option to break out of the loop
                userAnswer = char.Parse(Console.ReadLine().ToUpper());
                if (userAnswer == 'N')
                {
                    loop = false;
                }
                Console.Clear();
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadLine();
            }
        }

        static void FillMatrix(ref int[,] Matrix)
        {
            //KEY 1n = Linked directly by road. 0n = not linked directly by road. 2n = same location
            //Lancaster (0)
            Matrix[0, 0] = 10;
            Matrix[0, 1] = 137;
            Matrix[0, 2] = 126;
            Matrix[0, 3] = 050;
            Matrix[0, 4] = 062;
            Matrix[0, 5] = 056;

            //Blackpool (1)
            Matrix[1, 0] = 137;
            Matrix[1, 1] = 10;
            Matrix[1, 2] = 117;
            Matrix[1, 3] = 034;
            Matrix[1, 4] = 055;
            Matrix[1, 5] = 049;

            //Preston (2)
            Matrix[2, 0] = 126;
            Matrix[2, 1] = 117;
            Matrix[2, 2] = 10;
            Matrix[2, 3] = 120;
            Matrix[2, 4] = 136;
            Matrix[2, 5] = 133;

            //Southport (3)
            Matrix[3, 0] = 050;
            Matrix[3, 1] = 034;
            Matrix[3, 2] = 120;
            Matrix[3, 3] = 10;
            Matrix[3, 4] = 120;
            Matrix[3, 5] = 043;

            //Liverpool (4)
            Matrix[4, 0] = 062;
            Matrix[4, 1] = 055;
            Matrix[4, 2] = 136;
            Matrix[4, 3] = 120;
            Matrix[4, 4] = 10;
            Matrix[4, 5] = 135;

            //Manchester (5)
            Matrix[5, 0] = 056;
            Matrix[5, 1] = 049;
            Matrix[5, 2] = 133;
            Matrix[5, 3] = 044;
            Matrix[5, 4] = 135;
            Matrix[5, 5] = 10;
        }

        static void GetLocations(ref int[,] Matrix, ref string loc1, ref string loc2)
        {
            Console.WriteLine("Matrix Program");

            Console.WriteLine("Enter a town from the following: \nLancaster \nBlackpool \nPreston \nSouthport \nLiverpool \nManchester \n");

            Console.Write("Location 1:");
            loc1 = Console.ReadLine().ToLower();

            Console.Write("Location 2:");
            loc2 = Console.ReadLine().ToLower();

            Console.Clear();

        }

        static int Changetoint32(string input)
        {
            int output;

            switch (input)
            {
                case "lancaster":
                    output = 0;
                    break;
                case "blackpool":
                    output = 1;
                    break;
                case "preston":
                    output = 2;
                    break;
                case "southport":
                    output = 3;
                    break;
                case "liverpool":
                    output = 4;
                    break;
                case "manchester":
                    output = 5;
                    break;
                default:
                    return 666;
            }

            return output;
        }

        static void OutputConnectionandDistance(ref int[,] Matrix, int Loc1, int Loc2, string location1txt, string location2txt)
        {
            bool RoadConnection = false;
            
            if (Matrix[Loc1, Loc2].ToString().StartsWith("1") == true) //See if there is a Direct Road Connection (set as first digit = 1)
            {
                RoadConnection = true;
            }

            Console.WriteLine("Locations Chosen: {0} and {1}", location1txt.ToUpper(), location2txt.ToUpper());

            if (RoadConnection == true)
            {
                Console.WriteLine("There is a Direct Road Connection between these two locations, and the road length is: {0} miles", Matrix[Loc1, Loc2].ToString().TrimStart('1')); //Output the direct road connection, and trim the checkdigit off the front of the value.
            }
            else
            {
                Console.WriteLine("There is no Direct Road Connection between these two locations, However, the shortest distance by road is: {0} miles", Matrix[Loc1, Loc2].ToString().TrimStart('0')); //Identical to the other output, however the trim digit is different.
            }

        } 
    }

}
