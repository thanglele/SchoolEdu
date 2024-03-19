using QLSINHVIEN.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.BLL
{
    class Bll_SinhVien
    {
        DAL.Dal_SinhVien dalSinhVien;
        frm_SinhVien SV;
        public Bll_SinhVien(frm_SinhVien frm_SV)
        {
            dalSinhVien = new DAL.Dal_SinhVien();
            SV = frm_SV;
        }
        public void LoadGrid()
        {
            SV.dataGridView1.DataSource = dalSinhVien.LoadGrid();
        }
        public void LoadComBo()
        {
            SV.cb_Lop.DataSource = dalSinhVien.LoadComBo();
        }
        public void bllThem()
        {
            dalSinhVien.dalThem(SV.txt_MaSV.Text, SV.txt_TenSV.Text, SV.NgaySinh.Value, SV.cb_Lop.SelectedValue.ToString());
        }
        public void bllSua()
        {
            dalSinhVien.dalSua(SV.txt_TenSV.Text, SV.NgaySinh.Value, SV.cb_Lop.SelectedValue.ToString(), SV.txt_MaSV.Text);
        }
        public void bllXoa()
        {
            dalSinhVien.dalXoa(SV.txt_MaSV.Text);
        }
        public void bllTim()
        {
            SV.dataGridView1.DataSource = dalSinhVien.dalTim(SV.txt_TimKiem.Text);
        }
    }
}
