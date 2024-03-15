using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEdu
{
    internal class Account
    {
        private static Account _instance;
        public static Account Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Account();
                }
                return _instance;
            }
            private set { Instance = value; }
        }
        private Account() { }
        public bool login(string username, string password)
        {
            string ketnoi = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;;User ID=buimanhduc-database;Password=Buim@nhducsql2024;";
            using(SqlConnection connection = new SqlConnection(ketnoi))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SINHVIEN WHERE MaSV = @username AND MatKhau = @password";
                string query1 = "SELECT COUNT(*) FROM GIAOVIEN WHERE MaGV = @username AND MatKhau = @password";
                SqlCommand cmd = new SqlCommand(query1, connection);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                int count = (int)command.ExecuteScalar();
                int count1 = (int)cmd.ExecuteScalar();
                return count > 0 || count1 > 0;
            }
        }
    }
}
