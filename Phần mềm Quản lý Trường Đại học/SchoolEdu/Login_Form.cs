using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string ketnoi = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;Persist Security Info=True;User ID=buimanhduc-database;Password=***********;Encrypt=True;";
        SqlConnection conn = null;
        private void thoat_click(object sender, EventArgs e)
        {
            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm_Student student = new MainForm_Student();
            this.Hide();
            student.ShowDialog();
        }

        private void login_closing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
