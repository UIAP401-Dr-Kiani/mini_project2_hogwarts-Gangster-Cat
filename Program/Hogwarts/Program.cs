using System;
using System.Windows.Forms;

namespace Hogwarts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var MainForm = new Form1();
            if (new Human("Hello", "Hello", "adsa", "Male", "Golabi", "sadsad", "dasdasd", "12123dasd").Gender == null)
            {
                MainForm.IntroTimer.Enabled = true;
                MainForm.IntroTimer.Start();
            }

            Application.Run(MainForm);
        }
    }
}