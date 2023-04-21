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
            Application.Run(MainForm);
            
            
        }
    }
}