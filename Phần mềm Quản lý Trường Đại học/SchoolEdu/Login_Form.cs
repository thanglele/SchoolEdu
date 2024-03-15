using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SchoolEdu
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private bool isExiting = false;
        private void thoat_click(object sender, EventArgs e)
        {
            isExiting = true;
            Application.Exit();
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

        bool login(string username, string password)
        {
            return Account.Instance.login(username, password);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = dangnhap.Text;
            string password = matkhau.Text;
            if (login( username, password))
            {
                string status = comboBox1.SelectedItem.ToString();
                if (status == "Sinh Viên")
                {
                    MainForm_Student student = new MainForm_Student();
                    this.Hide();
                    student.ShowDialog();
                }
                else if (status == "Giảng Viên")
                {
                    MainForm_Teacher mainForm_Teacher = new MainForm_Teacher();
                    this.Hide();
                    mainForm_Teacher.ShowDialog();
                }
                else if (status == "Admin")
                {
                    MainForm_Admin admin = new MainForm_Admin();
                    this.Hide();
                    admin.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_closing(object sender, FormClosingEventArgs e)
        {
            if (!isExiting)
            {
                DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void login_combobox(object sender, EventArgs e)
        {

        }
    }
}
