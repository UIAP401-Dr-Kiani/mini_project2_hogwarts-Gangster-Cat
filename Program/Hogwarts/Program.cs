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
            LoginForm loginForm = new LoginForm();

            //First we should know who's the user!
            //=====================================================================
            ChooseRoleMsgForm chooseRoleMsgForm = new ChooseRoleMsgForm();
            chooseRoleMsgForm.EnteredRole = null;

            Application.Run(chooseRoleMsgForm);
            
            //After the chooseRoleMsgForm form have closed -->

            if (chooseRoleMsgForm.EnteredRole == PersonRole.Dumbledore)
            {
                loginForm.UserNameTextBox.Enabled = false;
                loginForm.UserNameTextBox.Text = "  Dumbledore";
            }
            else
            {
                //if is student or teacher
                loginForm.UserNameTextBox.Enabled = true;
            }

            //=====================================================================
            if (chooseRoleMsgForm.EnteredRole != null)
            {
                loginForm.IntroTimer.Enabled = true;
                Application.Run(loginForm);
            }




            Dumbledore dumbledore = new Dumbledore();
            List<Student> validStudents = new List<Student>();
            List<Teacher> validTeachers = new List<Teacher>();
            List<Human> regularHumans = new List<Human>();
            dumbledore.ValidateHumans(validStudents, validTeachers, regularHumans);



        }
    }
}