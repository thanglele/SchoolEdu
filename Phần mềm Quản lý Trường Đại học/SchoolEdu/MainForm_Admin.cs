using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolEdu
{
    public partial class MainForm_Admin : Form
    {
        public MainForm_Admin()
        {
            InitializeComponent();
        }

        private void MainForm_Admin_Load(object sender, EventArgs e)
        {
            var db = new database();
            dgvData.DataSource = db.SelectData();
        }
    }
}
