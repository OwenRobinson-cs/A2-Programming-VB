using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic;

namespace GuessingGameFORMAPP
{
    public partial class Form1 : Form
    {
        public static int Number = 0;
        public static int Guess;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void GenerateNumberBTN_Click(object sender, EventArgs e)
        {
            GenNumber();
            GenerateNumberBTN.Text = "Generated a Number";
            GenerateNumberBTN.BackColor = Color.GreenYellow;
        }

        static void GenNumber()
        {
            Random RNG = new Random();

            Number = RNG.Next(1, 501);

        }


        private void GuessBTN_Click(object sender, EventArgs e)
        {
            int CorrectGuesses = 0;
            int IncorrectGuesses = 0;
            int TotalGuess = 0;
            int.TryParse(UserGuessTXT.Text, out Guess);
            TotalGuess++;
            NumbersGuessedLBL.Text = NumbersGuessedLBL.Text + $"{Guess}, Total Guesses: {TotalGuess}";
            

            if (Guess == Number)
            {
                GuessBTN.Text = "Correct Guess";
                NumbersGuessedLBL.Text = "Numbers Guessed: ";
                GenerateNumberBTN.Text = "Generate Number";
                GenerateNumberBTN.BackColor = Color.Gray;

                //Change Correct Guesses
                CorrectGuesses = CorrectGuesses + 1;
                CorrectGuessesLBL.Text = $"Correct Guesses: {CorrectGuesses}";
            }
            else if (Guess > Number)
            {
                GuessBTN.Text = "Lower";
                IncorrectGuesses++;
                IncorrectGuessesLBL.Text = $"Incorrect Guesses: {IncorrectGuesses}";
            }
            else
            {
                GuessBTN.Text = "Higher";
                IncorrectGuesses++;
                IncorrectGuessesLBL.Text = $"Incorrect Guesses: {IncorrectGuesses}";
            }
        }
    }
}
