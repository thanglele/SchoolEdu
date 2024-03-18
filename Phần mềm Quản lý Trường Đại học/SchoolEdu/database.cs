using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolEdu
{
   public class database
    {
        private string connectionString = @"Data Source=172.188.28.154\sqlexpress;Initial Catalog = SchoolEdu_Database; User ID = tathihongngat-database;Password=Tathihongngat472004!";
        private System.Data.SqlClient.SqlConnection conn;
        private string sql;
        private readonly database dt;
        private System.Data.SqlClient.SqlCommand cmd;
        public database()
        {
            try
            {
                conn = new System.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("connected fail:"+ex.Message);
            }
        }

        public DataTable SelectData()
        {
            try
            {
                conn.Open();
                sql = "select * from SINHVIEN";
                cmd = new System.Data.SqlClient.SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi  load du lieu: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Load(System.Data.SqlClient.SqlDataReader sqlDataReader)
        {
            throw new NotImplementedException();
        }
    }
}
