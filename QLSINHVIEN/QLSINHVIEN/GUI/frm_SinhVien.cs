using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSINHVIEN.GUI
{
    public partial class frm_SinhVien : Form
    {
        BLL.Bll_SinhVien bllSinhVien;
        public frm_SinhVien()
        {
            bllSinhVien = new BLL.Bll_SinhVien(this);
            InitializeComponent();
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadComBo();
            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[3].HeaderText = "Lớp";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 171;

            //dataGridView1.Columns[1].HeaderText
        }
        public void LoadGrid()
        {
            bllSinhVien.LoadGrid();
        }
        public void LoadComBo()
        {
            bllSinhVien.LoadComBo();
            cb_Lop.DisplayMember = "MaLop";
            cb_Lop.ValueMember = "MaLop";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_MaSV.Text = dataGridView1.Rows[i].Cells["MaSV"].Value.ToString();
            txt_TenSV.Text = dataGridView1.Rows[i].Cells["TenSV"].Value.ToString();
            NgaySinh.Text = dataGridView1.Rows[i].Cells["NgaySinh"].Value.ToString();
            cb_Lop.SelectedValue = dataGridView1.Rows[i].Cells["MaLop"].Value.ToString();


        }
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txt_MaSV.Clear();
            txt_TenSV.Clear();
        }
        private void bt_Hủy_Click(object sender, EventArgs e)
        {
            txt_MaSV.Enabled = false;
            txt_TenSV.Enabled = false;
            NgaySinh.Enabled = false;
            cb_Lop.Enabled = false;
            bt_Hủy.Visible = false;
            bt_Reset.Visible = false;
        }
        string taikhoanSV = "";
        private void bt_Them_Click(object sender, EventArgs e)
        {
            taikhoanSV = frm_DangNhap.taikhoan;
            if (taikhoanSV.Equals("admin") || taikhoanSV.Equals("user"))
            {
                txt_MaSV.Enabled = true;
                txt_TenSV.Enabled = true
                NgaySinh.Enabled = true;
                cb_Lop.Enabled = true;
                bt_Hủy.Visible = true;
                bt_Reset.Visible = true;
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            taikhoanSV = frm_DangNhap.taikhoan;
            if (taikhoanSV.Equals("admin") || taikhoanSV.Equals("user"))
            {
                if (string.IsNullOrEmpty(txt_MaSV.Text))
                {
                    MessageBox.Show("Chưa Nhập Mã Sinh Viên");
                }
                else
                {
                    try
                    {
                        bllSinhVien.bllThem();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã Tồn Tại Mã Sinh Viên");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadGrid();
            LoadComBo();
            txt_MaSV.ResetText();
            txt_TenSV.ResetText();
          
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            taikhoanSV = frm_DangNhap.taikhoan;
            if (taikhoanSV.Equals("admin") || taikhoanSV.Equals("user"))
            {
                txt_MaSV.Enabled = true;
                txt_TenSV.Enabled = true;
          
                NgaySinh.Enabled = true;
                cb_Lop.Enabled = true;
                bt_Hủy.Visible = true;
                bt_Reset.Visible = true;
                if (string.IsNullOrEmpty(txt_MaSV.Text))
                {
                    MessageBox.Show("Chưa Nhập Sinh Viên Cần Sửa");
                }
                else
                {
                    MessageBox.Show("Sửa Thành Công");
                    bllSinhVien.bllSua();
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadGrid();
        }
        public static string maSV = "", tenSV = "", ngaySinh = "", sdt = "", maLop = "";
        internal object txt_SDT;
        private object frm_DangNhap;

        private void bt_ChiTiet_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ChiTiet"] == null)
            {
                if (string.IsNullOrEmpty(txt_MaSV.Text))
                {
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    string masv = txt_MaSV.Text;
                    string tensv = txt_TenSV.Text;
                    string ns = NgaySinh.Text;
                 
                    string malop = cb_Lop.Text;

                    maSV = masv;
                    tenSV = tensv;
                    ngaySinh = ns;
  
                    maLop = malop;
                    frm_ChiTiet ct = new frm_ChiTiet();
                    ct.ShowDialog();
                }
            }
            else
            {
                Application.OpenForms["frm_ChiTiet"].Activate();
            }



        }

        private void cb_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            taikhoanSV = frm_DangNhap.taikhoan;
            if (taikhoanSV.Equals("admin") || taikhoanSV.Equals("user"))
            {

                if (string.IsNullOrEmpty(txt_MaSV.Text))
                {
                    MessageBox.Show("Chưa Nhập Sinh Viên Cần Xóa");
                }
                else
                {
                    DialogResult thongbao;
                    thongbao = MessageBox.Show("Bạn Có Muốn Xóa Sinh Viên Này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (thongbao == DialogResult.Yes)
                    {
                        try
                        {
                            bllSinhVien.bllXoa();
                        }
                        catch
                        {
                            MessageBox.Show("Có Lỗi");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadGrid();
        }
        private void bt_Tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKiem.Text))
            {
                MessageBox.Show("Chưa Nhập Sinh Viên Cần Tìm");
            }
            else
            {
                try
                {
                    bllSinhVien.bllTim();
                }
                catch { MessageBox.Show("Không Có Sinh Viên Cần Tìm"); }
            }
        }
        private void Tim_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Tim.PerformClick();
            }
        }

        private void bt_LoadLai_Click(object sender, EventArgs e)
        {
            LoadGrid();
            txt_TimKiem.ResetText();
        }
    }
}
