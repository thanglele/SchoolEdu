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
    public partial class frm_ChiTiet : Form
    {
        public frm_ChiTiet()
        {
            InitializeComponent();
        }

        private void bt_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string mSV = "", tSV = "", birth = "", ml = "";

        private void frm_ChiTiet_Load(object sender, EventArgs e)
        {
            mSV = frm_SinhVien.maSV;
            tSV = frm_SinhVien.tenSV;
            birth = frm_SinhVien.ngaySinh;
            ml = frm_SinhVien.maLop;

            lb_MaSV.Text = mSV;
            lb_TenSV.Text = tSV;
            lb_NgaySinh.Text = birth;
            lb_MaLop.Text = ml;
        }
    }
}
