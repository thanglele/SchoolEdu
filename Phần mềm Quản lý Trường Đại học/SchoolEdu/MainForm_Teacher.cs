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
    public partial class MainForm_Teacher : Form
    {
        public MainForm_Teacher()
        {
            InitializeComponent();
        }

        private void MainForm_Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
