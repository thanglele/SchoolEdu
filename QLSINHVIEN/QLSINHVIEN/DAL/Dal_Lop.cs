using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    class Dal_Lop
    {
        KetNoi kn;
        public Dal_Lop()
        {
            kn = new KetNoi();
        }
        public DataTable LoadLop()
        {
            string loadLop = "select * from Lop";
            return kn.Load_Data(loadLop);
        }
        public void dalThem(string maLop, string khoa, string nienKhoa)
        {
            string dalThem = "insert into Lop values('" + maLop + "','" + khoa + "','" + nienKhoa + "')";
            kn.Nonquery(dalThem);
        }
        public void dalSua(string khoa, string nienKhoa, string maLop)
        {
            string dalSua = "update Lop set Khoa ='" + khoa + "', NienKhoa ='" + nienKhoa + "' where MaLop = '" + maLop + "'";
            kn.Nonquery(dalSua);
        }
        public void dalXoa(string maLop)
        {
            string dalXoa = "delete from Lop where MaLop ='" + maLop + "'";
            kn.Nonquery(dalXoa);
        }
    }
}
