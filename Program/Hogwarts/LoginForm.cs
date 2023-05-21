using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class LoginForm : Form
    {
        public LoginForm(List<Student> _students)
        {
            InitializeComponent();
            this.IntroTimer.Enabled = true;
            this.ESCNotifyTimer.Enabled = true;
            Students = _students;
            RoleProc = PersonRole.Student;
            this.KeyPreview = true;
        }
        public LoginForm(List<Teacher> _teachers)
        {
            InitializeComponent();
            this.IntroTimer.Enabled = true;
            this.ESCNotifyTimer.Enabled = true;
            Teachers = _teachers;
            RoleProc = PersonRole.Teacher;
            this.KeyPreview = true;
        }
        public LoginForm(Dumbledore _dumbledore)
        {
            InitializeComponent();
            this.IntroTimer.Enabled = true;
            this.ESCNotifyTimer.Enabled = true;
            Dumbledore = _dumbledore;
            RoleProc = PersonRole.Dumbledore;
            this.KeyPreview = true;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.025;
            else
                IntroTimer.Stop();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            void passwordProc()
            {
                if (RoleProc == PersonRole.Student)
                {
                    if (MainMethods.IsUserInfoCorrect(Students, this.UserNameTextBox.Text, this.PasswordTextBox.Text))
                        this.UserNameLabel.Text = "Hello";
                    else
                    {
                        this.NotFoundLabel.ForeColor = Color.Red;
                        this.NotFoundLabel.Text = "Username or Password is incorrect!";
                    }
                }
                else if (RoleProc == PersonRole.Teacher)
                {
                    if (MainMethods.IsUserInfoCorrect(Teachers, this.UserNameTextBox.Text, this.PasswordTextBox.Text))
                        this.UserNameLabel.Text = "Hello";
                    else
                    {
                        this.NotFoundLabel.ForeColor = Color.Red;
                        this.NotFoundLabel.Text = "Username or Password is incorrect!";
                    }
                }
                else if (RoleProc == PersonRole.Dumbledore)
                {
                    if (MainMethods.IsUserInfoCorrect(Dumbledore, this.PasswordTextBox.Text))
                        this.UserNameLabel.Text = "Hello";
                    else
                    {
                        this.NotFoundLabel.ForeColor = Color.Red;
                        this.NotFoundLabel.Text = "Password is incorrect!";
                    }
                }
                UsersProcThread.Abort();
            }

            ThreadStart UsersProcThread_S = new ThreadStart(passwordProc);
            UsersProcThread = new Thread(UsersProcThread_S);
            UsersProcThread.Start();

        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
        //--------------------------------------------------------
        private static List<Student> Students { get; set; }
        private static List<Teacher> Teachers { get; set; }
        private static Dumbledore Dumbledore { get; set; }
        private static PersonRole RoleProc { get; set; }
        private static Thread UsersProcThread { get; set; }

        private void ESCNotifyTimer_Tick(object sender, EventArgs e)
        {
            if (this.ESCNotify.ForeColor.B != 0)
                this.ESCNotify.ForeColor = System.Drawing.Color.FromArgb(this.ESCNotify.ForeColor.R - 1, this.ESCNotify.ForeColor.G - 1, this.ESCNotify.ForeColor.B - 1);
            else
                ESCNotifyTimer.Stop();
        }
    }
}