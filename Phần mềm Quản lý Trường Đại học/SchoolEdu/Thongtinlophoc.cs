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
    public partial class Thongtinlophoc : UserControl
    {
        public Thongtinlophoc()
        {
            InitializeComponent();
        }
        string ketnoi = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;;User ID=buimanhduc-database;Password=Buim@nhducsql2024;";
        private void Thongtinlophoc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90,0,0,0);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            string text = comboBox1.SelectedValue.ToString();
            SqlConnection sqlConnection = new SqlConnection(ketnoi);
            sqlConnection.Open();
            string sql = "Select * from LOP where MaLop = @text";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@text", text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        private void thoat_click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void getdulieulop()
        {
            SqlConnection sql = new SqlConnection(ketnoi);
            sql.Open();
            string conn = "Select MaLop from LOP";
            SqlDataAdapter adp = new SqlDataAdapter(conn, sql);
            DataTable data = new DataTable();
            adp.Fill(data);
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "MaLop";
            comboBox1.ValueMember = "MaLop";
        }
        //public void timkiem(string dulieu)
        //{
            
        //    SqlConnection sqlConnection = new SqlConnection(ketnoi);
        //    sqlConnection.Open();
        //    string sql = "Select * from LOP where MaLop = comboBox1.SelectedValue.ToString()";
            
        //}
    }
}
