using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts
{
    public partial class ChooseRoleMsgForm : Form
    {
        public ChooseRoleMsgForm()
        {
            InitializeComponent();
        }
        private object RoleValidation()
        {
            if (StudentRadio.Checked)
                return PersonRole.Student;
            else if (TeacherRadio.Checked)
                return PersonRole.Teacher;
            else if (DumbledoreRadio.Checked)
                return PersonRole.Dumbledore;
            else
            {
                WhoLabel.Text = "Choose one first!";
                WhoLabel.ForeColor = System.Drawing.Color.FromArgb(211, 166, 37);
                return 0;
            }
        }
        public void OkButton_Click(object sender, EventArgs e)
        {
            if (RoleValidation().GetType() != typeof(int))
            {
                EnteredRole = (PersonRole)RoleValidation();
                this.Close();
            }
        }
        //Properties
        public PersonRole? EnteredRole { get; set; }
    }
}
