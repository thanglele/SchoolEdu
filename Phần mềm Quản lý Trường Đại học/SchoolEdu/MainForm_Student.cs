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
    public partial class MainForm_Student : Form
    {
        public MainForm_Student()
        {
            InitializeComponent();
        }
        Login_Form login = new Login_Form();
        private void logout_click(object sender, EventArgs e)
        {
            login.Show();
            Close();
        }

        private void ttsv_click(object sender, EventArgs e)
        {
            Thongtinsinhvien ttsv = new Thongtinsinhvien();
            panel1.Controls.Add(ttsv);
            ttsv.BringToFront();
        }

        private void sinhvien_click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(sinhvien.sv))
            {
                panel1.Controls.Add(sinhvien.sv);
                sinhvien.sv.BringToFront();
            }
        }

        private void ttlh_click(object sender, EventArgs e)
        {
            Thongtinlophoc ttlh = new Thongtinlophoc(); 
            panel1.Controls.Add(ttlh);
            ttlh.BringToFront();
        }

        private void dky_click(object sender, EventArgs e)
        {
            dangkyhoc dky = new dangkyhoc();
            panel1.Controls.Add(dky);   
            dky.BringToFront();
        }
    }
}
