using System;
using System.IO;

namespace DiceCricket
{

    class MainClass
    {

        //Skeleton Program code for Year 12 January Comp Sci Test
        //written by the AQA COMP1 Programmer Team
        //Student Name: Owen Robinson
        //School: Ramsey Grammar School
        //Date: 07/12/2020 | 10/01/2020

        const int MaxSize = 4;
        static int OptionSelected = 0;

        public static void Main()
        {
            string[] TopScoreNames = new string[MaxSize + 1];
            int[] TopScoreScores = new int[MaxSize + 1];
            string PlayerOneName = null;
            string PlayerTwoName = null;
            ResetTopScores(ref TopScoreNames, ref TopScoreScores);
            Console.Write("WhFat is player one's name? ");
            GetValidPlayerName(ref PlayerOneName);
            Console.Write("What is player two's name? ");
            GetValidPlayerName(ref PlayerTwoName);
            do
            {
                do
                {
                    DisplayMenu();
                    GetMenuChoice();
                } while (!((OptionSelected >= 1 & OptionSelected <= 4) | OptionSelected == 9));
                Console.WriteLine();
                if (OptionSelected >= 1 & OptionSelected <= 4)
                {
                    switch (OptionSelected)
                    {
                        case 1:
                            PlayDiceGame(PlayerOneName, PlayerTwoName, true, ref TopScoreNames, ref TopScoreScores);
                            break;
                        case 2:
                            PlayDiceGame(PlayerOneName, PlayerTwoName, false, ref TopScoreNames, ref TopScoreScores);
                            break;
                        case 3:
                            LoadTopScores(ref TopScoreNames, ref TopScoreScores);
                            break;
                        case 4:
                            DisplayTopScores(TopScoreNames, TopScoreScores);
                            break;
                    }
                }
            } while (OptionSelected != 9);
        }

        public static void ResetTopScores(ref string[] TopScoreNames, ref int[] TopScoreScores)
        {
            int Count = 0;
            for (Count = 1; Count <= MaxSize; Count++)
            {
                TopScoreNames[Count] = "-";
                TopScoreScores[Count] = 0;
            }
        }

        public static void GetValidPlayerName(ref string PlayerName)
        {

            do
            {
                PlayerName = Console.ReadLine();
                if (string.IsNullOrEmpty(PlayerName))
                {
                    Console.Write("That is not a valid name.  Please try again: ");
                }
            } while (!(!string.IsNullOrEmpty(PlayerName)));

        }

        public static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Dice Cricket");
            Console.WriteLine();
            Console.WriteLine("1.  Play game version with virtual dice");
            Console.WriteLine("2.  Play game version with real dice");
            Console.WriteLine("3.  Load top scores");
            Console.WriteLine("4.  Display top scores");
            Console.WriteLine("9.  Quit");
            Console.WriteLine();
        }

        public static void GetMenuChoice()
        {
            Console.Write("Please enter your choice: ");
            OptionSelected = int.Parse(Console.ReadLine());
            if (OptionSelected < 1 | (OptionSelected > 4 | OptionSelected != 9))
            {
                Console.WriteLine();
                Console.WriteLine("That was not one of the allowed options.  Please try again: ");
            }

        }
       
        public static void RollBowlDie(bool VirtualDiceGame, ref int BowlDieResult)
        {
            Random rnd = new Random();
            if (VirtualDiceGame)
            {
                BowlDieResult = rnd.Next(1, 6 + 1);
            }
            else
            {
                int Input = 0;
                while (Input == 0)
                {
                    Console.WriteLine("Please roll the bowling die and then enter your result.");
                    Console.WriteLine();
                    Console.WriteLine("Enter 1 if the result is a 1");
                    Console.WriteLine("Enter 2 if the result is a 2");
                    Console.WriteLine("Enter 3 if the result is a 4");
                    Console.WriteLine("Enter 4 if the result is a 6");
                    Console.WriteLine("Enter 5 if the result is a 0");
                    Console.WriteLine("Enter 6 if the result is OUT");
                    Console.WriteLine();
                    Console.Write("Result: ");
                    int.TryParse(Console.ReadLine(), out Input);

                    if (Input < 1 || Input > 6)
                    {
                        Console.WriteLine("Please Enter a Value between 1 and 6");
                    }
                }
                BowlDieResult = Input;
                Console.WriteLine();
            }
        }

        public static void CalculateRunsScored(int BowlDieResult, ref int RunsScored)
        {
            switch (BowlDieResult)
            {
                case 1:
                    RunsScored = 1;
                    break;
                case 2:
                    RunsScored = 2;
                    break;
                case 3:
                    RunsScored = 4;
                    break;
                case 4:
                    RunsScored = 6;
                    break;
                case 5:
                case 6:
                    RunsScored = 0;
                    break;
            }
        }

        public static void DisplayRunsScored(int RunsScored)
        {
            switch (RunsScored)
            {
                case 1:
                    Console.WriteLine("You got one run!");
                    break;
                case 2:
                    Console.WriteLine("You got two runs!");
                    break;
                case 4:
                    Console.WriteLine("You got four runs!");
                    break;
                case 6:
                    Console.WriteLine("You got six runs!");
                    break;
            }
        }

        public static void DisplayCurrentPlayerNewScore(int CurrentPlayerScore)
        {
            Console.WriteLine("Your new score is: " + CurrentPlayerScore);
        }

        public static void RollAppealDie(bool VirtualDiceGame, ref int AppealDieResult)
        {
            Random rnd = new Random();

            if (VirtualDiceGame)
            {
                AppealDieResult = rnd.Next(1, 5 + 1);
            }
            else
            {
                Console.WriteLine("Please roll the appeal die and then enter your result.");
                Console.WriteLine();
                Console.WriteLine("Enter 1 if the result is NOT OUT");
                Console.WriteLine("Enter 2 if the result is CAUGHT");
                Console.WriteLine("Enter 3 if the result is LBW");
                Console.WriteLine("Enter 4 if the result is BOWLED");
                Console.WriteLine("Enter 5 if the result is RUN OUT");
                Console.WriteLine();
                Console.Write("Result: ");
                AppealDieResult = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

        }

        public static void DisplayAppealDieResult(int AppealDieResult)
        {
            switch (AppealDieResult)
            {
                case 1:
                    Console.WriteLine("Not out!");
                    break;
                case 2:
                    Console.WriteLine("Caught!");
                    break;
                case 3:
                    Console.WriteLine("LBW!");
                    break;
                case 4:
                    Console.WriteLine("Bowled!");
                    break;
                case 5:
                    Console.WriteLine("RUN OUT");
                    break;
            }
        }

        public static void DisplayResult(string PlayerOneName, int PlayerOneScore, string PlayerTwoName, int PlayerTwoScore)
        {
            Console.WriteLine();
            Console.WriteLine(PlayerOneName + " your score was: " + PlayerOneScore);
            Console.WriteLine(PlayerTwoName + " your score was: " + PlayerTwoScore);
            Console.WriteLine();

            if (PlayerOneScore > PlayerTwoScore)
            {
                Console.WriteLine(PlayerOneName + " wins!");
            }
            if (PlayerTwoScore > PlayerOneScore)
            {
                Console.WriteLine(PlayerTwoName + " wins!");
            }
            Console.WriteLine();
        }

        public static void UpdateTopScores(ref string[] TopScoreNames, ref int[] TopScoreScores, string PlayerName, int PlayerScore)
        {
            int LowestCurrentTopScore = 0;
            int PositionOfLowestCurrentTopScore = 0;
            int Count = 0;
            LowestCurrentTopScore = TopScoreScores[1];
            PositionOfLowestCurrentTopScore = 1;
            // Find the lowest of the current top scores        
            for (Count = 2; Count <= MaxSize; Count++)
            {
                if (TopScoreScores[Count] < LowestCurrentTopScore)
                {
                    LowestCurrentTopScore = TopScoreScores[Count];
                    PositionOfLowestCurrentTopScore = Count;
                }
            }
            if (PlayerScore > LowestCurrentTopScore)
            {
                TopScoreScores[PositionOfLowestCurrentTopScore] = PlayerScore;
                TopScoreNames[PositionOfLowestCurrentTopScore] = PlayerName;
                Console.WriteLine("Well done " + PlayerName + " you have one of the top scores!");
            }
        }

        public static void DisplayTopScores(string[] TopScoreNames, int[] TopScoreScores)
        {
            int Count = 0;
            Console.WriteLine("The current top scores are: ");
            Console.WriteLine();
            for (Count = 1; Count <= MaxSize; Count++)
            {
                Console.WriteLine(TopScoreNames[Count] + " " + TopScoreScores[Count]);
            }
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to return to the main menu");
            Console.ReadLine();
        }

        public static void LoadTopScores(ref string[] TopScoreNames, ref int[] TopScoreScores)
        {
            int Count = 0;
            int Count2 = 0;
            string LineFromFile = null;
            string[] ValuesOnLine = new string[3];
            StreamReader CurrentFile = new StreamReader("HiScores.txt");

            for (Count = 1; Count <= MaxSize; Count++)
            {
                ValuesOnLine[1] = "";
                ValuesOnLine[2] = "";
                LineFromFile = CurrentFile.ReadLine();
                Count2 = 0;
                do
                {
                    ValuesOnLine[1] = ValuesOnLine[1] + LineFromFile[Count2];
                    Count2 = Count2 + 1;
                } while (LineFromFile[Count2] != ',');
                Count2 = Count2 + 1;
                do
                {
                    ValuesOnLine[2] = ValuesOnLine[2] + LineFromFile[Count2];
                    Count2 = Count2 + 1;
                } while (!(Count2 == LineFromFile.Length));
                TopScoreNames[Count] = ValuesOnLine[1];
                TopScoreScores[Count] = Convert.ToInt32(ValuesOnLine[2]);
            }
            CurrentFile.Close();
        }

        public static void PlayDiceGame(string PlayerOneName, string PlayerTwoName, bool VirtualDiceGame, ref string[] TopScoreNames, ref int[] TopScoreScores)
        {
            bool PlayerOut = false;
            int CurrentPlayerScore = 0;
            int AppealDieResult = 0;
            int PlayerNo = 0;
            int PlayerOneScore = 0;
            int PlayerTwoScore = 0;
            int BowlDieResult = 0;
            int RunsScored = 0;
            for (PlayerNo = 1; PlayerNo <= 2; PlayerNo++)
            {
                CurrentPlayerScore = 0;
                PlayerOut = false;
                Console.WriteLine();
                if (PlayerNo == 1)
                {
                    Console.WriteLine(PlayerOneName + " is batting");
                }
                else
                {
                    Console.WriteLine(PlayerTwoName + " is batting");
                }
                Console.WriteLine();
                Console.WriteLine("Press the Enter key to continue");
                Console.ReadLine();
                do
                {
                    RollBowlDie(VirtualDiceGame, ref BowlDieResult);
                    if (BowlDieResult >= 1 & BowlDieResult <= 4)
                    {
                        CalculateRunsScored(BowlDieResult, ref RunsScored);
                        DisplayRunsScored(RunsScored);
                        CurrentPlayerScore = CurrentPlayerScore + RunsScored;
                        Console.WriteLine("Your new score is: " + CurrentPlayerScore);
                    }
                    if (BowlDieResult == 5)
                    {
                        Console.WriteLine("No runs scored this time.  Your score is still: " + CurrentPlayerScore);
                    }
                    if (BowlDieResult == 6)
                    {
                        Console.WriteLine("This could be out... press the Enter key to find out.");
                        Console.ReadLine();
                        RollAppealDie(VirtualDiceGame, ref AppealDieResult);
                        DisplayAppealDieResult(AppealDieResult);
                        if (AppealDieResult >= 2)
                        {
                            PlayerOut = true;
                        }
                        else
                        {
                            PlayerOut = false;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press the Enter key to continue");
                    Console.ReadLine();
                } while (!(PlayerOut));
                Console.WriteLine("You are out.  Your final score was: " + CurrentPlayerScore);
                Console.WriteLine();
                Console.Write("Press the Enter key to continue");
                Console.ReadLine();
                if (PlayerNo == 1)
                {
                    PlayerOneScore = CurrentPlayerScore;
                }
                else
                {
                    PlayerTwoScore = CurrentPlayerScore;
                }
            }
            DisplayResult(PlayerOneName, PlayerOneScore, PlayerTwoName, PlayerTwoScore);
            if (PlayerOneScore >= PlayerTwoScore)
            {
                UpdateTopScores(ref TopScoreNames, ref TopScoreScores, PlayerOneName, PlayerOneScore);
                UpdateTopScores(ref TopScoreNames, ref TopScoreScores, PlayerTwoName, PlayerTwoScore);
            }
            else
            {
                UpdateTopScores(ref TopScoreNames, ref TopScoreScores, PlayerTwoName, PlayerTwoScore);
                UpdateTopScores(ref TopScoreNames, ref TopScoreScores, PlayerOneName, PlayerOneScore);
            }
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}