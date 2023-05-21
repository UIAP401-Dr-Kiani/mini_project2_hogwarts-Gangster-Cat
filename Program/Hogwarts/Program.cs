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

            //Generating Humans and dumbledore first(Main Thread) -->
            Dumbledore dumbledore = new Dumbledore();
            dumbledore.Password = "1234";

            List<Student> validStudents = new List<Student>();
            List<Teacher> validTeachers = new List<Teacher>();
            List<Human> regularHumans = new List<Human>();
            dumbledore.ValidateHumans(validStudents, validTeachers, regularHumans);

            //=====================================================================================

            ChooseRoleMsgForm chooseRoleMsgForm = new ChooseRoleMsgForm();

            Application.Run(chooseRoleMsgForm);

            //After the chooseRoleMsgForm form have closed -->

            if (chooseRoleMsgForm.EnteredRole == PersonRole.Dumbledore)
            {
                LoginForm loginForm = new LoginForm(dumbledore);
                loginForm.UserNameTextBox.Enabled = false;
                loginForm.UserNameTextBox.Text = $" Dumbledore";
                Application.Run(loginForm);
            }
            else if (chooseRoleMsgForm.EnteredRole == PersonRole.Student)
            {
                LoginForm loginForm = new LoginForm(validStudents);
                Application.Run(loginForm);
            }
            else if (chooseRoleMsgForm.EnteredRole == PersonRole.Teacher)
            {
                LoginForm loginForm = new LoginForm(validTeachers);
                Application.Run(loginForm);
            }



        }
    }
}