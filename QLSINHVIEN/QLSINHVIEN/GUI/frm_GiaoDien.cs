using QLSINHVIEN.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN
{
    public partial class frm_GiaoDien : Form
    {
        frm_DangNhap dn;
        public frm_GiaoDien()
        {
            dn = new frm_DangNhap();
            InitializeComponent();
        }
        /*        public frm_GiaoDien(string tendangnhap, string matkhau, string quyen)
                {
                    InitializeComponent();
                    this.tendangnhap = tendangnhap;
                    this.matkhau = matkhau;
                    this.quyen = quyen;
                }*/

        string taikhoanGD = "";
        private void frm_GiaoDien_Load(object sender, EventArgs e)
        {
            taikhoanGD = frm_DangNhap.taikhoan;
            lb_TenTK.Text = taikhoanGD;
            if (lb_TenTK.Text.Equals("admin"))
            {
                bt_TaiKhoan.Visible = true;
                pictureBox4.Visible = true;
            }
        }
        private Form currentFormChild;
        private object bt_TaiKhoan;
        private object pn_TK;
        private object pictureBox4;

        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childform);
            panel_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void bt_SinhVien_Click(object sender, EventArgs e)
        {
            pn_SV.Visible = true;
            pn_Lop.Visible = false;
            pn_TK.Visible = false;
            OpenChildForm(new frm_SinhVien());
            label2.Text = "Quản Lý " + bt_SinhVien.Text;
        }
        private void bt_Lop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Lop());
            label2.Text = "Quản Lý " + bt_Lop.Text;
            pn_Lop.Visible = true;
            pn_SV.Visible = false;
            pn_TK.Visible = false;
        }
        private void bt_TaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TaiKhoan());
            label2.Text = "Quản Lý" + bt_TaiKhoan.Text;
            pn_TK.Visible = true;
            pn_Lop.Visible = false;
            pn_SV.Visible = false;
        }
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult Thoat;
            Thoat = MessageBox.Show("Bạn Có Muốn Thoát ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dangxuat;
            dangxuat = MessageBox.Show("Bạn Có Muốn Đăng Xuất ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dangxuat == DialogResult.Yes)
            {
                this.Close();
                frm_DangNhap dn = new frm_DangNhap();
                dn.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 247)
            {
                panel1.Width = 69;
            }
            else
            {
                panel1.Width = 247;
            }
        }
    }
}
