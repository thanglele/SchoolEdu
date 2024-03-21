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
    public partial class QLSV : Form
    {
        String connectstring=  @"Data Source=172.188.28.154;User ID=tathihongngat-database;Password=***********";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public QLSV()
        {
            InitializeComponent();
        }
        private void QLSV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }
        public DataTable Load_Data(string sqlData)
        {
            adt = new SqlDataAdapter(sqlData, con);
            dt = new DataTable();

            adt.Fill(dt);
            return dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtMaSV.Text != "")
            {
                if(txtTenSV.Text != "")
                {
                    if(cbGioiTinh.Text != "")
                    {
                        if(txtLop.Text != "")
                        {
                            if(txtDiaChi.Text != "")
                            {
                                if(txtNganh.Text != "")
                                {
                                    dataGridViewSinhVien.Rows.Add(txtMaSV,txtTenSV,dateTimePicker1,cbGioiTinh,txtDiaChi,txtLop,txtNganh)
                                }
                                else
                                {
                                    MessageBox.Show("chưa thông tin Ngành  ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("chưa thông tin Địa chỉ  ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("chưa thông tin Lớp ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("chưa thông tin Giới tính ");
                    }
                }
                else
                {
                    MessageBox.Show("chưa thông tin Tên sinh viên  ");
                }
            }
            else
            {
                MessageBox.Show("chưa thông tin Mã sinh viên ");
            }
        }
        
          
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dataGridViewSinhVien.SelectedRows.Count > 0)
            {
                int vitri = dataGridViewSinhVien.CurrentCell.RowIndex;
                dataGridViewSinhVien[0, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[1, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[2, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[3, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[4, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[5, vitri].Value = txtMaSV.Text;
                dataGridViewSinhVien[6, vitri].Value = txtMaSV.Text;
            }
        }

  
    }
}
