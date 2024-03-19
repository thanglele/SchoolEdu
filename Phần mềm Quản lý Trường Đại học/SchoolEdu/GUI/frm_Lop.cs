using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN.GUI
{
    public partial class frm_Lop : Form
    {
        BLL.Bll_Lop bllLop;
        public frm_Lop()
        {
            bllLop = new BLL.Bll_Lop(this);
            InitializeComponent();
        }
        private void frm_Lop_Load(object sender, EventArgs e)
        {
            LoadLop();
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Khoa";
            dataGridView1.Columns[2].HeaderText = "Niên Khóa";

            dataGridView1.Columns[0].Width = 330;
            dataGridView1.Columns[1].Width = 460;
            dataGridView1.Columns[2].Width = 330;
        }
        public void LoadLop()
        {
            bllLop.bllLoadLop();
        }
        private void bt_Hủy_Click(object sender, EventArgs e)
        {
            txt_MaLop.Enabled = false;
            txt_Khoa.Enabled = false;
            txt_NienKhoa.Enabled = false;
            bt_Hủy.Visible = false;
            bt_Reset.Visible = false;
        }
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txt_MaLop.ResetText();
            txt_Khoa.ResetText();
            txt_NienKhoa.ResetText();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_MaLop.Text = dataGridView1.Rows[i].Cells["MaLop"].Value.ToString();
            txt_Khoa.Text = dataGridView1.Rows[i].Cells["Khoa"].Value.ToString();
            txt_NienKhoa.Text = dataGridView1.Rows[i].Cells["NienKhoa"].Value.ToString();
        }
        string taikhoanLop = "";
        private void bt_Them_Click(object sender, EventArgs e)
        {
            taikhoanLop = frm_DangNhap.taikhoan;
            if (taikhoanLop.Equals("admin") || taikhoanLop.Equals("user"))
            {
                txt_MaLop.Enabled = true;
                txt_Khoa.Enabled = true;
                txt_NienKhoa.Enabled = true;
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
            taikhoanLop = frm_DangNhap.taikhoan;
            if (taikhoanLop.Equals("admin") || taikhoanLop.Equals("user"))
            {
                if (string.IsNullOrEmpty(txt_MaLop.Text))
                {
                    MessageBox.Show("Chưa Nhập Mã Sinh Viên");
                }
                else
                {
                    try
                    {
                        bllLop.bllThemLop();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã Tồn Tại Mã Lớp");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadLop();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            taikhoanLop = frm_DangNhap.taikhoan;
            if (taikhoanLop.Equals("admin") || taikhoanLop.Equals("user"))
            {
                txt_MaLop.Enabled = true;
                txt_Khoa.Enabled = true;
                txt_NienKhoa.Enabled = true;
                bt_Hủy.Visible = true;
                bt_Reset.Visible = true;
                if (string.IsNullOrEmpty(txt_MaLop.Text))
                {
                    MessageBox.Show("Chưa Nhập Sinh Viên Cần Sửa");
                }
                else
                {
                    MessageBox.Show("Sửa Thành Công");
                    bllLop.bllSuaLop();
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadLop();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            taikhoanLop = frm_DangNhap.taikhoan;
            if (taikhoanLop.Equals("admin") || taikhoanLop.Equals("user"))
            {
                if (string.IsNullOrEmpty(txt_MaLop.Text))
                {
                    MessageBox.Show("Chưa Lớp Cần Xóa");
                }
                else
                {
                    DialogResult thongbao;
                    thongbao = MessageBox.Show("Bạn Có Muốn Xóa Lớp Này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (thongbao == DialogResult.Yes)
                    {
                        bllLop.bllXoaLop();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadLop();
        }
    }
}
