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
using System.Collections;

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

            get_information_User();
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

                    New_Password.Text = Recover_New_Password.Text = Old_Password.Text = "";
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
            get_information_User();
            Main.SelectedIndex = 0;
        }

        private void get_information_User()
        {
            connection.Open();
            FE_Magiaovien.Text = ID;
            FE_Hovaten.Text = User_menu.Text;
            
            string query = "select NgaySinh from GIAOVIEN where MaGV = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Ngaysinh.Text = Convert.ToString(command.ExecuteScalar());
            try
            {
                FE_Ngaysinh.Text = FE_Ngaysinh.Text.Replace(" 12:00:00 SA", "");
            }
            catch (Exception)
            {

            }

            query = "select GioiTinh from GIAOVIEN where MaGV = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Gioitinh.Text = Convert.ToString(command.ExecuteScalar());

            query = "select DiaChi from GIAOVIEN where MaGV = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Diachi.Text = Convert.ToString(command.ExecuteScalar());

            query = "select MaLop from LOP where MaGV = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Lopchunhiem.Text = Convert.ToString(command.ExecuteScalar());

            query = "select Khoa from LOP where MaGV = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Khoa.Text = Convert.ToString(command.ExecuteScalar());

            query = "select Nganh from LOP where MaGV = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Chuyennganh.Text = Convert.ToString(command.ExecuteScalar());

            query = "select Nienkhoa from LOP where MaGV = @ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Khoadaotao.Text = Convert.ToString(command.ExecuteScalar());
            connection.Close();
        }

        private void Button_DSlopchunhiem_Click(object sender, EventArgs e)
        {
            Main.SelectedIndex = 1;
            getdataclassmate_chunhiem();
        }

        private void getdataclassmate_chunhiem()
        {
            connection.Open();
            string query = "select MaLop from LOP where MaGV = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Lopchunhiem_page2.Text = Convert.ToString(command.ExecuteScalar());

            query = "select MaSV, TenSV, NgaySinh, GioiTinh, DiaChi from SINHVIEN where MaLop = @IDClass";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDClass", FE_Lopchunhiem_page2.Text);

            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            Danhsachlopchunhiem.DataSource = dataTable;
            
            Danhsachlopchunhiem.Columns["MaSV"].HeaderText = "Mã sinh viên";
            Danhsachlopchunhiem.Columns["TenSV"].HeaderText = "Họ và tên";
            Danhsachlopchunhiem.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            Danhsachlopchunhiem.Columns["GioiTinh"].HeaderText = "Giới tính";
            Danhsachlopchunhiem.Columns["DiaChi"].HeaderText = "Địa chỉ";

            connection.Close();
        }

        private void Button_QLdaotaochunhiem_Click(object sender, EventArgs e)
        {
            loadDataDaotaochunhiem();
            Main.SelectedIndex = 2;
        }

        private void loadDataDaotaochunhiem()
        {
            connection.Open();
            string query = "select MaLop from LOP where MaGV = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            FE_Lopchunhiem_page2.Text = Convert.ToString(command.ExecuteScalar());

            query = "select SINHVIEN.MaSV, TenSV, NgaySinh, GioiTinh, MaLop, MaMH, Ngaybatdau, Ngayketthuc, SoTC from SINHVIEN inner join SVMH on SINHVIEN.MaSV = SVMH.MaSV where MaLop = @IDClass";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDClass", FE_Lopchunhiem_page2.Text);

            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Bangdangkymonthanhcong.DataSource = dataTable;

            Bangdangkymonthanhcong.Columns["MaSV"].HeaderText = "Mã sinh viên";
            Bangdangkymonthanhcong.Columns["TenSV"].HeaderText = "Họ và tên";
            Bangdangkymonthanhcong.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            Bangdangkymonthanhcong.Columns["GioiTinh"].HeaderText = "Giới tính";
            Bangdangkymonthanhcong.Columns["MaLop"].HeaderText = "Mã lớp";
            Bangdangkymonthanhcong.Columns["MaMH"].HeaderText = "Mã môn học";
            Bangdangkymonthanhcong.Columns["Ngaybatdau"].HeaderText = "Ngày bắt đầu";
            Bangdangkymonthanhcong.Columns["NgayKetthuc"].HeaderText = "Ngày kết thúc";
            Bangdangkymonthanhcong.Columns["SoTC"].HeaderText = "Số tín chỉ";

            connection.Close();
        }

        private void Button_Diemtonghopsv_Click(object sender, EventArgs e)
        {
            Main.SelectedIndex = 3;
        }

        private void Button_Ketquadangkyhocsv_Click(object sender, EventArgs e)
        {
            Main.SelectedIndex = 4;
        }

        private void Button_QLdaotao_Click(object sender, EventArgs e)
        {
            Main.SelectedIndex = 5;
        }

        private void F5_Click(object sender, EventArgs e)
        {
            loadDataDaotaochunhiem();
        }
    }
}
