using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolEdu
{
    public partial class dangkyhoc : UserControl
    {
        public dangkyhoc()
        {
            InitializeComponent();
        }
        string dangkyhoc1 = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;User ID=buimanhduc-database;Password=Buim@nhducsql2024";
        SqlConnection conn = new SqlConnection();
        private void dangkyhoc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(90, 0, 0, 0);

        }

        //lay du lieu tu bang
        public DataTable GetData()
        {
            conn = new SqlConnection();
            conn.Open();
            string sql = "Select * from MONHOC";
            SqlDataAdapter dki = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dki.Fill(dt);
            return dt;
        }
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void getmonhoc(string monhoc)
        {
            SqlConnection sqlConnection = new SqlConnection(dangkyhoc1);
            sqlConnection.Open();
            string sql = "Select * from MONHOC";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void gettinhoc(string tinhoc)
        {
            SqlConnection sqlConnection = new SqlConnection(dangkyhoc1);
            sqlConnection.Open();
            string sql = "Select * from SVMH where MaSV = @SV";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@SV", tinhoc);
            SqlDataAdapter adp = new SqlDataAdapter(sqlCommand) ;
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void monhoc_celldoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow = dataGridView2.Rows[e.RowIndex];
            string ma = Convert.ToString(dataGridViewRow.Cells[0].Value);
            SqlConnection sqlConnection = new SqlConnection(dangkyhoc1);
            sqlConnection.Open();
            string sql = "Select * from GVMH where MaMH = @dataGridViewRow";
            SqlCommand sqlCommand = new SqlCommand( sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@dataGridViewRow", ma);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand) ;
            DataTable dataTable = new DataTable() ;
            sqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;  
        }

        private void GV_MH_celldoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = new DataGridViewRow();
            data = dataGridView4.Rows[e.RowIndex];
            DataGridViewRow data1 = new DataGridViewRow();
            data1 = dataGridView2.Rows[e.RowIndex];
            DataGridViewRow data2 = new DataGridViewRow();
            data2 = dataGridView1.Rows[e.RowIndex];
            string ma = Convert.ToString(data2.Cells[0].Value);
            SqlConnection sqlConnection = new SqlConnection(dangkyhoc1);
            sqlConnection.Open();

            
            if (MessageBox.Show("Bạn có đki môn học này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mamh = Convert.ToString(data.Cells[1].Value);
                //string ngaybd = Convert.ToString(data.Cells[2].Value);
                //string ngaykt = Convert.ToString(data.Cells[5].Value);
                string sotc = Convert.ToString(data1.Cells[2].Value);
                string insert = "Insert into SVMH values(@ma, @mamh, @ngaybd, @ngaykt, @sotc)";

                SqlCommand sql = new SqlCommand(insert, sqlConnection);
                sql.Parameters.AddWithValue("@ma", ma);
                sql.Parameters.AddWithValue("@mamh", mamh);
                sql.Parameters.AddWithValue("@ngaybd", data.Cells[2].Value);
                sql.Parameters.AddWithValue("@ngaykt", data.Cells[5].Value);
                sql.Parameters.AddWithValue("@sotc", sotc);
                try
                {
                    sql.ExecuteScalar();
                    string sql1 = "Select * from SVMH where MaSV = @SV";
                    SqlCommand sqlCommand = new SqlCommand(sql1, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@SV", ma);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    MessageBox.Show("Đăng ký môn học thành công", "Thông báo");
                }
                catch (Exception)
                {
                    MessageBox.Show("Môn học này đã được đăng ký sẵn, vui lòng chọn môn khác", "Thông báo");
                }
            }
            
        }
    }
}
