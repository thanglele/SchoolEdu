using Microsoft.Identity.Client;
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
    public partial class sinhvien : UserControl
    {
        public sinhvien()
        {
            InitializeComponent();
        }

        private void sinhvien_Load(object sender, EventArgs e)
        {

        }
        private static sinhvien _sv;
        public static sinhvien sv
        {
            get
            {
                if (_sv == null)
                {
                    _sv = new sinhvien();
                }
                return _sv;
            }
        }

    }
}
