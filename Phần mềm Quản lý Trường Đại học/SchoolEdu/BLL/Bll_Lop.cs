using QLSINHVIEN.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.BLL
{
    class Bll_Lop
    {
        DAL.Dal_Lop dalLop;
        frm_Lop lop;
        public Bll_Lop(frm_Lop f_lop)
        {
            dalLop = new DAL.Dal_Lop();
            lop = f_lop;
        }
        public void bllLoadLop()
        {
            lop.dataGridView1.DataSource = dalLop.LoadLop();
        }
        public void bllThemLop()
        {
            dalLop.dalThem(lop.txt_MaLop.Text, lop.txt_Khoa.Text, lop.txt_NienKhoa.Text);
        }
        public void bllSuaLop()
        {
            dalLop.dalSua(lop.txt_Khoa.Text, lop.txt_NienKhoa.Text, lop.txt_MaLop.Text);
        }
        public void bllXoaLop()
        {
            dalLop.dalXoa(lop.txt_MaLop.Text);
        }
    }
}
