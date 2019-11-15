using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRMbeepinator : Form
    {
        public FRMbeepinator()
        {
            InitializeComponent();
        }

        private void FRMbeepinator_Load(object sender, EventArgs e)
        {
             //hi
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdtheBeepinator_Click(object sender, EventArgs e)
        {
            if (txtInputinator.Text.Trim().Length == 0 )
            {
                MessageBox.Show("You Must Enter a Name");
            }
            else
            {
                MessageBox.Show("Hello " + txtInputinator.Text);
                txtInputinator.ForeColor = Color.Beige;
                txtInputinator.BackColor = Color.Black;
            }
           
        }
    }
}
