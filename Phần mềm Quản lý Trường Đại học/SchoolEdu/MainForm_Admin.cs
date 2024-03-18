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
    public partial class MainForm_Admin : Form
    {
        public MainForm_Admin()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;Persist Security Info=True;User ID=lethanhluong-database;Password=***********";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Admin_Load(object sender, EventArgs e)
        {
            
            ketnoi = new SqlConnection(chuoiketnoi);

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

     


        private void điachi_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void them_Click(object sender, EventArgs e)
        {
            

                

            }


            






        }
    }
}
