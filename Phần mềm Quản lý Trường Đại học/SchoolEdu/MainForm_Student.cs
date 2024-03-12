using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolEdu
{
    public partial class MainForm_Student : Form
    {
        public MainForm_Student()
        {
            InitializeComponent();
        }
        Login_Form login = new Login_Form();
        private void logout_click(object sender, EventArgs e)
        {
            login.Show();
        }

        private void student_closing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }
    }
}
