using System;
using System.Collections.Generic;
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
            ChooseRoleMsgForm chooseRoleMsgForm = new ChooseRoleMsgForm();
            LoginForm loginForm = new LoginForm();
            Application.Run(chooseRoleMsgForm);

            //First we should know who's the user!
            //=====================================================================
            if (chooseRoleMsgForm.EnteredRole == PersonRole.Dumbledore)
            {
                loginForm.BackColor = System.Drawing.Color.Aqua;
            }
            else if (chooseRoleMsgForm.EnteredRole == PersonRole.Student)
            {
                loginForm.BackColor = System.Drawing.Color.Blue;
            }
            else
            {
                //If is Teacher -->
               loginForm.BackColor = System.Drawing.Color.Green;
            }
            //=====================================================================
               loginForm.IntroTimer.Enabled = true;

            Application.Run(loginForm);



            Dumbledore dumbledore = new Dumbledore();
            List<Student> validStudents = new List<Student>();
            List<Teacher> validTeachers = new List<Teacher>();
            List<Human> regularHumans = new List<Human>();
            dumbledore.ValidateHumans(validStudents,validTeachers,regularHumans);
            
            
            
        }
    }
}