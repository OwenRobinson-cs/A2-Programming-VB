namespace GuessingGameFORMAPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateNumberBTN = new System.Windows.Forms.Button();
            this.UserGuessTXT = new System.Windows.Forms.TextBox();
            this.NumbersGuessedLBL = new System.Windows.Forms.Label();
            this.GuessBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CorrectGuessesLBL = new System.Windows.Forms.Label();
            this.IncorrectGuessesLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateNumberBTN
            // 
            this.GenerateNumberBTN.BackColor = System.Drawing.Color.Gray;
            this.GenerateNumberBTN.Location = new System.Drawing.Point(12, 404);
            this.GenerateNumberBTN.Name = "GenerateNumberBTN";
            this.GenerateNumberBTN.Size = new System.Drawing.Size(82, 34);
            this.GenerateNumberBTN.TabIndex = 0;
            this.GenerateNumberBTN.Text = "Generate Number";
            this.GenerateNumberBTN.UseVisualStyleBackColor = false;
            this.GenerateNumberBTN.Click += new System.EventHandler(this.GenerateNumberBTN_Click);
            // 
            // UserGuessTXT
            // 
            this.UserGuessTXT.Location = new System.Drawing.Point(306, 194);
            this.UserGuessTXT.Name = "UserGuessTXT";
            this.UserGuessTXT.Size = new System.Drawing.Size(156, 20);
            this.UserGuessTXT.TabIndex = 1;
            // 
            // NumbersGuessedLBL
            // 
            this.NumbersGuessedLBL.AutoSize = true;
            this.NumbersGuessedLBL.Location = new System.Drawing.Point(9, 23);
            this.NumbersGuessedLBL.Name = "NumbersGuessedLBL";
            this.NumbersGuessedLBL.Size = new System.Drawing.Size(100, 13);
            this.NumbersGuessedLBL.TabIndex = 2;
            this.NumbersGuessedLBL.Text = "Numbers Guessed: ";
            // 
            // GuessBTN
            // 
            this.GuessBTN.BackColor = System.Drawing.Color.Gray;
            this.GuessBTN.Location = new System.Drawing.Point(350, 220);
            this.GuessBTN.Name = "GuessBTN";
            this.GuessBTN.Size = new System.Drawing.Size(82, 34);
            this.GuessBTN.TabIndex = 3;
            this.GuessBTN.Text = "Guess";
            this.GuessBTN.UseVisualStyleBackColor = false;
            this.GuessBTN.Click += new System.EventHandler(this.GuessBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Generated will be between 1 and 500";
            // 
            // CorrectGuessesLBL
            // 
            this.CorrectGuessesLBL.AutoSize = true;
            this.CorrectGuessesLBL.Location = new System.Drawing.Point(9, 36);
            this.CorrectGuessesLBL.Name = "CorrectGuessesLBL";
            this.CorrectGuessesLBL.Size = new System.Drawing.Size(91, 13);
            this.CorrectGuessesLBL.TabIndex = 5;
            this.CorrectGuessesLBL.Text = "Correct Guesses: ";
            // 
            // IncorrectGuessesLBL
            // 
            this.IncorrectGuessesLBL.AutoSize = true;
            this.IncorrectGuessesLBL.Location = new System.Drawing.Point(9, 49);
            this.IncorrectGuessesLBL.Name = "IncorrectGuessesLBL";
            this.IncorrectGuessesLBL.Size = new System.Drawing.Size(99, 13);
            this.IncorrectGuessesLBL.TabIndex = 6;
            this.IncorrectGuessesLBL.Text = "Incorrect Guesses: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 470);
            this.Controls.Add(this.IncorrectGuessesLBL);
            this.Controls.Add(this.CorrectGuessesLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuessBTN);
            this.Controls.Add(this.NumbersGuessedLBL);
            this.Controls.Add(this.UserGuessTXT);
            this.Controls.Add(this.GenerateNumberBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateNumberBTN;
        private System.Windows.Forms.TextBox UserGuessTXT;
        private System.Windows.Forms.Label NumbersGuessedLBL;
        private System.Windows.Forms.Button GuessBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CorrectGuessesLBL;
        private System.Windows.Forms.Label IncorrectGuessesLBL;
    }
}

