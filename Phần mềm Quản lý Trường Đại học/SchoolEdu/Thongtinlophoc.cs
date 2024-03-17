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
        string ketnoi = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;;User ID=tluedu_application;Password=LeTh@ng2884;";
        private void Thongtinlophoc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90,0,0,0);    
            SqlConnection conn2 = new SqlConnection(ketnoi);
            conn2.Open();
            string sql = "Select * from LOP";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Enabled = false;
            

        }

        private void thoat_click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
           
        }
        
    }
}
