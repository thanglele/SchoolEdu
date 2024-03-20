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
            // TODO: This line of code loads data into the 'schoolEdu_DatabaseDataSet5.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter1.Fill(this.schoolEdu_DatabaseDataSet5.GIAOVIEN);
            // TODO: This line of code loads data into the 'schoolEdu_DatabaseDataSet4.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.schoolEdu_DatabaseDataSet4.GIAOVIEN);

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

        string taikhoangiaovien = " ";
        private void them_Click(object sender, EventArgs e)
        {
            /*
            if(taikhoangiaovien.Equals("admin") || taikhoangiaovien.Equals("user"))
            {
                txt_ txt_MaGV.Enabled = true;
                txt_ txt_TenGV.Enabled = true;
                txt_ txt_NgaySinh.Enabled = true;
                txt_ txt_DiaChi.Enabled = true;

            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

        
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            /*
            if (taikhoangiaovien.Equals("admin") || taikhoangiaovien.Equals("user"))
            {
                txt_ txt_MaGV.Enabled = false;
                txt_ txt_TenGV.Enabled = false;
                txt_ txt_NgaySinh.Enabled = false;
                txt_ txt_DiaChi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_ txt_MaGV.Text = dataGridView1.Rows[i].Cells["MaGV"].Value.ToString();
            txt_ txt_TenGV.Text = dataGridView1.Rows[i].Cells["TenGV"].Value.ToString();
            txt_ txt_NgaySinh.Text = dataGridView1.Rows[i].Cells["NgaySinh"].Value.ToString();
            txt_ txt_DiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
            */
        }

        private void sua_Click(object sender, EventArgs e)
        {
            /*
            if(taikhoangiaovien.Equals("admin") || taikhoangiaovien.Equals("user"))
            {
                txt_ txt_MaGV.Enabled = true;
                txt_ txt_TenGV.Enabled = true;
                txt_ txt_NgaySinh.Enabled = true;
                txt_ txt_DiaChi.Enabled = true;
                if (string.IsNullOrEmpty(txt_MaGV.Text))
                {
                    MessageBox.Show("Chưa Nhập Giáo Viên Cần Sửa");
                }
                else
                {
                    MessageBox.Show("Sửa Thành Công");
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }

        private void luu_Click(object sender, EventArgs e)
        {
            /*
            if (taikhoangiaovien.Equals("admin") || taikhoangiaovien.Equals("user"))
            {
                if (string.IsNullOrEmpty(txt_MaGV.Text))
                {
                    MessageBox.Show("Chưa Nhập Mã Giáo Viên");
                }
                else
                {
                    try
                    {
                        MessageBox.Show("Thêm Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã Tồn Tại Mã Giáo Viên");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }
            
        
    }
        
}
