using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Gowtham Talluri
// Student #: 200335297
// Description: This form is about the Order form
// Date: march 5th 2017

namespace COMP1004_Assignment3_Movie
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // splash form functionality
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            SelectionForm select = new SelectionForm();
            select.Show();
            this.Hide();

        }
    }
}
