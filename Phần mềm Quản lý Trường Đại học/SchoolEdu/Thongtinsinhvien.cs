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
    public partial class Thongtinsinhvien : UserControl
    {
        public Thongtinsinhvien()
        {
            InitializeComponent();
        }

        private void Thongtinsinhvien_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private static Thongtinsinhvien _TTSV;
        public static Thongtinsinhvien TTSV
        {
            get
            {
                if (_TTSV == null)
                {
                    _TTSV = new Thongtinsinhvien();
                }
                return _TTSV;
            }
        }
    }
}
