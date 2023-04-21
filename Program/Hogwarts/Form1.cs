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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.025;
            else
                IntroTimer.Stop();
                   
        }
    }
}