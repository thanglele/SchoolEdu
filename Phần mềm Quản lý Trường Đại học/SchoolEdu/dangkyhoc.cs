using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolEdu
{
    public partial class dangkyhoc : UserControl
    {
        public dangkyhoc()
        {
            InitializeComponent();
        }
        string dangkyhoc1 = "Data Source=172.188.28.154;Initial Catalog=SchoolEdu_Database;Persist Security Info=True;User ID=buimanhduc-database;Password=Buim@nhducsql2024;Encrypt=True";
        SqlConnection conn = new SqlConnection();
        private void dangkyhoc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(90, 0, 0, 0);

        }

        //lay du lieu tu bang
        public DataTable GetData()
        {
            conn = new SqlConnection();
            conn.Open();
            string sql = "Select * from MONHOC";
            SqlDataAdapter dki = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dki.Fill(dt);
            return dt;
        }
        void HienThi_MonHoc()
        {
            DataTable dt = new DataTable();
            dt = GetData();
            ListViewItem lv;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[1].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(subitem);
                listView1.Items.Add(item);
            }
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
