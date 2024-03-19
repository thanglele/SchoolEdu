using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    class Dal_SinhVien
    {
        KetNoi kn;
        public Dal_SinhVien()
        {
            kn = new KetNoi();
        }
        public DataTable LoadGrid()
        {
            string loadGrid = "select * from SINHVIEN";
            return kn.Load_Data(loadGrid);
        }
        public DataTable LoadComBo()
        {
            string loadComBo = "select MaLop from Lop";
            return kn.Load_Data(loadComBo);
        }
        public void dalThem(string maSV, string tenSV, DateTime ngaySinh, int soDT, string maLop)
        {
            string dalThem = "insert into SinhVien values('" + maSV + "', N'" + tenSV + "', Convert(Datetime,'" + ngaySinh + "',103), '" + maLop + "')";
            kn.Nonquery(dalThem);
        }

        internal void dalThem(string text1, string text2, DateTime value, string v)
        {
            throw new NotImplementedException();
        }

        internal void dalSua(string text1, DateTime value, string v, string text2)
        {
            throw new NotImplementedException();
        }

        public void dalSua(string tenSV, DateTime ngaySinh, int soDT, string maLop, string maSV)
        {
            string dalSua = "update SINHVIEN set TenSV = N'" + tenSV + "', NgaySinh = Convert(Datetime,'" + ngaySinh + "',103),  MaLop = '" + maLop + "' where MaSV = N'" + maSV + "'";
            kn.Nonquery(dalSua);
        }
        public void dalXoa(string maSV)
        {
            string dalXoa = "delete from SINHVIEN where MaSV = '" + maSV + "'";
            kn.Nonquery(dalXoa);
        }
        public DataTable dalTim(string timKiem)
        {
            string dalTim = "select * from SINHVIEN where MaSV like '%" + timKiem + "%' or TenSV like N'%" + timKiem + "%'";
            return kn.Load_Data(dalTim);
        }
    }
}
