using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSINHVIEN
{
    class KetNoi
    {
        string ketnoi = @"Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;Persist Security Info=True;User ID=tathihongngat-database;Password=Tathihongngat472004!;Encrypt=True";
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(ketnoi);
        }
        SqlDataAdapter da;
        DataTable dt;
        public DataTable Load_Data(string sqlData)
        {
            da = new SqlDataAdapter(sqlData, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) MessageBox.Show("Thành Công");
                else MessageBox.Show("Có Lỗi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Catch!, ....");
            }
            conn.Close();
        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
