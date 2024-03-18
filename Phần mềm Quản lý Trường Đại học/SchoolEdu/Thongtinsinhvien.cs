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
    public partial class Thongtinsinhvien : UserControl
    {
        public Thongtinsinhvien()
        {
            InitializeComponent();
        }
        string ketnoi = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;;User ID=buimanhduc-database;Password=Buim@nhducsql2024;";

        private void Thongtinsinhvien_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        
        public void getname(string nhan)
        {
            
            SqlConnection sqlConnection = new SqlConnection(ketnoi);
            sqlConnection.Open();
            string sql = "Select * from SINHVIEN where MaSV = @SV";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@SV", nhan);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                textBox1.Text = row["MaSV"].ToString();
                textBox2.Text = row["TenSV"].ToString();
                textBox3.Text = row["GioiTinh"].ToString();
                textBox4.Text = row["DiaChi"].ToString();
                textBox5.Text = row["NgaySinh"].ToString();
            }
        }
        
    }
}
