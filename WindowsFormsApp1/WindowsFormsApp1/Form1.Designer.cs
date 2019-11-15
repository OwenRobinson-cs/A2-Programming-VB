namespace WindowsFormsApp1
{
    partial class FRMbeepinator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMbeepinator));
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtInputinator = new System.Windows.Forms.TextBox();
            this.cmdtheBeepinator = new System.Windows.Forms.Button();
            this.picCancer = new System.Windows.Forms.PictureBox();
            this.cmdAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCancer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblEnterName.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(53, 177);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(148, 22);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter Name: ";
            // 
            // txtInputinator
            // 
            this.txtInputinator.Cursor = System.Windows.Forms.Cursors.No;
            this.txtInputinator.Location = new System.Drawing.Point(207, 177);
            this.txtInputinator.Name = "txtInputinator";
            this.txtInputinator.Size = new System.Drawing.Size(100, 20);
            this.txtInputinator.TabIndex = 1;
            // 
            // cmdtheBeepinator
            // 
            this.cmdtheBeepinator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdtheBeepinator.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmdtheBeepinator.Location = new System.Drawing.Point(336, 289);
            this.cmdtheBeepinator.Name = "cmdtheBeepinator";
            this.cmdtheBeepinator.Size = new System.Drawing.Size(63, 23);
            this.cmdtheBeepinator.TabIndex = 2;
            this.cmdtheBeepinator.Text = "Continue";
            this.cmdtheBeepinator.UseVisualStyleBackColor = false;
            this.cmdtheBeepinator.Click += new System.EventHandler(this.cmdtheBeepinator_Click);
            // 
            // picCancer
            // 
            this.picCancer.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._220px_Boris_johnson__cropped_;
            this.picCancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCancer.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCancer.InitialImage")));
            this.picCancer.Location = new System.Drawing.Point(12, 12);
            this.picCancer.Name = "picCancer";
            this.picCancer.Size = new System.Drawing.Size(46, 47);
            this.picCancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancer.TabIndex = 3;
            this.picCancer.TabStop = false;
            // 
            // cmdAbort
            // 
            this.cmdAbort.Location = new System.Drawing.Point(12, 289);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(75, 23);
            this.cmdAbort.TabIndex = 4;
            this.cmdAbort.Text = "Abort";
            this.cmdAbort.UseVisualStyleBackColor = true;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // FRMbeepinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._220px_Boris_johnson__cropped_;
            this.ClientSize = new System.Drawing.Size(411, 324);
            this.Controls.Add(this.cmdAbort);
            this.Controls.Add(this.picCancer);
            this.Controls.Add(this.cmdtheBeepinator);
            this.Controls.Add(this.txtInputinator);
            this.Controls.Add(this.lblEnterName);
            this.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMbeepinator";
            this.Text = "Immidate Action Needed";
            this.Load += new System.EventHandler(this.FRMbeepinator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCancer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtInputinator;
        private System.Windows.Forms.Button cmdtheBeepinator;
        private System.Windows.Forms.PictureBox picCancer;
        private System.Windows.Forms.Button cmdAbort;
    }
}

