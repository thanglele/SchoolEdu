namespace SchoolEdu
{
    partial class MainForm_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sinhvien = new System.Windows.Forms.Button();
            this.giangvien = new System.Windows.Forms.Button();
            this.lop = new System.Windows.Forms.Button();
            this.diem = new System.Windows.Forms.Button();
            this.monhoc = new System.Windows.Forms.Button();
            this.khoa = new System.Windows.Forms.Button();
            this.dangxuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolEdu.Properties.Resources.logo_thuyloi;
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sinhvien
            // 
            this.sinhvien.Location = new System.Drawing.Point(39, 150);
            this.sinhvien.Name = "sinhvien";
            this.sinhvien.Size = new System.Drawing.Size(110, 23);
            this.sinhvien.TabIndex = 1;
            this.sinhvien.Text = "SINH VIÊN";
            this.sinhvien.UseVisualStyleBackColor = true;
            // 
            // giangvien
            // 
            this.giangvien.Location = new System.Drawing.Point(39, 190);
            this.giangvien.Name = "giangvien";
            this.giangvien.Size = new System.Drawing.Size(110, 23);
            this.giangvien.TabIndex = 2;
            this.giangvien.Text = "GIẢNG VIÊN";
            this.giangvien.UseVisualStyleBackColor = true;
            // 
            // lop
            // 
            this.lop.Location = new System.Drawing.Point(39, 229);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(110, 23);
            this.lop.TabIndex = 3;
            this.lop.Text = "LỚP";
            this.lop.UseVisualStyleBackColor = true;
            // 
            // diem
            // 
            this.diem.Location = new System.Drawing.Point(39, 268);
            this.diem.Name = "diem";
            this.diem.Size = new System.Drawing.Size(110, 23);
            this.diem.TabIndex = 4;
            this.diem.Text = "ĐIỂM";
            this.diem.UseVisualStyleBackColor = true;
            // 
            // monhoc
            // 
            this.monhoc.Location = new System.Drawing.Point(39, 308);
            this.monhoc.Name = "monhoc";
            this.monhoc.Size = new System.Drawing.Size(110, 23);
            this.monhoc.TabIndex = 5;
            this.monhoc.Text = "MÔN HỌC";
            this.monhoc.UseVisualStyleBackColor = true;
            // 
            // khoa
            // 
            this.khoa.Location = new System.Drawing.Point(39, 348);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(110, 23);
            this.khoa.TabIndex = 6;
            this.khoa.Text = "KHÓA";
            this.khoa.UseVisualStyleBackColor = true;
            // 
            // dangxuat
            // 
            this.dangxuat.Location = new System.Drawing.Point(12, 415);
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(113, 23);
            this.dangxuat.TabIndex = 7;
            this.dangxuat.Text = "ĐĂNG XUẤT";
            this.dangxuat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(185, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 404);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = global::SchoolEdu.Properties.Resources.anhtlu;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(603, 404);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dangxuat);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.monhoc);
            this.Controls.Add(this.diem);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.giangvien);
            this.Controls.Add(this.sinhvien);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm_Admin";
            this.Text = "MainForm_Admin";
            this.Load += new System.EventHandler(this.MainForm_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sinhvien;
        private System.Windows.Forms.Button giangvien;
        private System.Windows.Forms.Button lop;
        private System.Windows.Forms.Button diem;
        private System.Windows.Forms.Button monhoc;
        private System.Windows.Forms.Button khoa;
        private System.Windows.Forms.Button dangxuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}