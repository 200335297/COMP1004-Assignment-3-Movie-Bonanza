using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Gowtham Talluri
// Student #: 200335297
// Description: This form is about the Order form
// Date: march 5th 2017

namespace COMP1004_Assignment3_Movie
{
    static class Program
    {
        public static MovieAndGenre info = new MovieAndGenre();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
