using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolEdu
{
    public partial class MainForm_Teacher : Form
    {
        private static string string_sql = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;User ID=tluedu_application;Password=LeTh@ng2884;";
        private SqlConnection connection = new SqlConnection(string_sql);
        private static string ID;
        public MainForm_Teacher()
        {
            InitializeComponent();

            connection.Open();
            ID = Login_Form.getID();
            string query = "select TenGV from GIAOVIEN where MaGV = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            User_menu.Text = Convert.ToString(command.ExecuteScalar());
            connection.Close();
        }

        private void MainForm_Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.SelectedIndex = 6;
        }

        private void Change_Password_task()
        {
            connection.Open();
            string query = "select MatKhau from GIAOVIEN where MaGV = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            string variable_old_password = Convert.ToString(command.ExecuteScalar());
            if (Old_Password.Text == variable_old_password)
            {
                if (New_Password.Text == Recover_New_Password.Text && New_Password != Old_Password && New_Password.Text.Length >= 8 && Recover_New_Password.Text.Length >= 8)
                {
                    query = "update GIAOVIEN set MatKhau = @newPassWord where MaGV = @ID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newPassWord", New_Password.Text);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteScalar();
                    MessageBox.Show("Mật khẩu thay đổi thành công!", "Thông báo");
                }
                else
                {
                    if (New_Password == Old_Password)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Cảnh báo");
                    }
                    else
                    {
                        if(New_Password.Text.Length < 8 || Recover_New_Password.Text.Length < 8)
                        {
                            MessageBox.Show("Mật khẩu cần lớn hơn 8 ký tự!", "Cảnh báo");
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu mới chưa trùng khớp!", "Cảnh báo");
                        }    
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ nhập chưa chính xác!", "Cảnh báo");
            }
            connection.Close();
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            Change_Password_task();
        }

        private void Old_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Change_Password_task();
            }    
        }

        private void New_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Change_Password_task();
            }
        }

        private void Recover_New_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Change_Password_task();
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.SelectedIndex = 0;
        }
    }
}
