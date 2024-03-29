﻿using Azure.Identity;
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
        private static string ID;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void exit_task()
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void thoat_click(object sender, EventArgs e)
        {
            //exit_task();
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
        bool login1(string username, string password)
        {
            return Account.Instance.login1(username, password); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = dangnhap.Text;
            string password = matkhau.Text;
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    
                    if (login(username, password))
                    {
                        string dulieu = dangnhap.Text.ToString();
                        MainForm_Student mainForm_Student = new MainForm_Student(dulieu);
                        this.Hide();
                        mainForm_Student.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (login1(username, password))
                    {
                        ID = username;
                        MainForm_Teacher mainForm_teacher = new MainForm_Teacher();
                        this.Hide();
                        mainForm_teacher.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if(comboBox1.SelectedIndex == 2)
                {
                    if (login1(username, password))
                    {
                        MainForm_Admin mainForm_admin = new MainForm_Admin();
                        this.Hide();
                        mainForm_admin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }    
                else
                {
                    MessageBox.Show("Bạn chưa chọn thuộc tính để đăng nhập");
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }


        }

        private void login_closing(object sender, FormClosingEventArgs e)
        {
            //exit_task();
            ////Application.Exit();
            ///if (!isExiting)
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

        public static string getID()
        {
            return ID;
        }
        public string getname()
        {
            return dangnhap.Text;
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
