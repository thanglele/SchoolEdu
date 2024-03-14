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
    public partial class Thongtinlophoc : UserControl
    {
        public Thongtinlophoc()
        {
            InitializeComponent();
        }
        private static Thongtinlophoc _ttlh;
        public static Thongtinlophoc ttlh
        {
            get
            {
                if (_ttlh == null)
                {
                    _ttlh = new Thongtinlophoc();
                }
                return _ttlh;
            }
        }
        private void Thongtinlophoc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90,0,0,0);    
        }  
    }
}
