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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void thoat_click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Bạn có chắc chắn muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes)
            {
                Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                matkhau.PasswordChar = (char)0;
            }
            else
            {
                matkhau.PasswordChar = '*';
            }
        }
    }
}
