using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            
        }
    }
}