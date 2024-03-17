namespace SchoolEdu
{
    partial class MainForm_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.sinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýHọcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tổngGpaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhvien2 = new SchoolEdu.sinhvien();
            this.sinhvien1 = new SchoolEdu.sinhvien();
            this.thongtinsinhvien1 = new SchoolEdu.Thongtinsinhvien();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sinhvien2);
            this.panel1.Controls.Add(this.sinhvien1);
            this.panel1.Controls.Add(this.thongtinsinhvien1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 575);
            this.panel1.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(1054, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(130, 33);
            this.logout.TabIndex = 3;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_click);
            // 
            // sinhToolStripMenuItem
            // 
            this.sinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinhToolStripMenuItem.Name = "sinhToolStripMenuItem";
            this.sinhToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.sinhToolStripMenuItem.Text = "Sinh Viên";
            this.sinhToolStripMenuItem.Click += new System.EventHandler(this.sinhvien_click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 29);
            this.toolStripMenuItem1.Text = "Thông tin sinh viên";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ttsv_click);
            // 
            // đăngKýHọcToolStripMenuItem
            // 
            this.đăngKýHọcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngKýHọcToolStripMenuItem.Name = "đăngKýHọcToolStripMenuItem";
            this.đăngKýHọcToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.đăngKýHọcToolStripMenuItem.Text = "Thông tin lớp học";
            this.đăngKýHọcToolStripMenuItem.Click += new System.EventHandler(this.ttlh_click);
            // 
            // đăngKýHọcToolStripMenuItem1
            // 
            this.đăngKýHọcToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngKýHọcToolStripMenuItem1.Name = "đăngKýHọcToolStripMenuItem1";
            this.đăngKýHọcToolStripMenuItem1.Size = new System.Drawing.Size(128, 29);
            this.đăngKýHọcToolStripMenuItem1.Text = "Đăng ký học";
            this.đăngKýHọcToolStripMenuItem1.Click += new System.EventHandler(this.dky_click);
            // 
            // traCứuHọcPhíToolStripMenuItem
            // 
            this.traCứuHọcPhíToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuHọcPhíToolStripMenuItem.Name = "traCứuHọcPhíToolStripMenuItem";
            this.traCứuHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.traCứuHọcPhíToolStripMenuItem.Text = "Học phí";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhToolStripMenuItem,
            this.toolStripMenuItem1,
            this.đăngKýHọcToolStripMenuItem,
            this.đăngKýHọcToolStripMenuItem1,
            this.traCứuHọcPhíToolStripMenuItem,
            this.tổngGpaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tổngGpaToolStripMenuItem
            // 
            this.tổngGpaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tổngGpaToolStripMenuItem.Name = "tổngGpaToolStripMenuItem";
            this.tổngGpaToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.tổngGpaToolStripMenuItem.Text = "Tổng GPA";
            // 
            // sinhvien2
            // 
            this.sinhvien2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sinhvien2.BackgroundImage")));
            this.sinhvien2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sinhvien2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhvien2.Location = new System.Drawing.Point(0, 0);
            this.sinhvien2.Name = "sinhvien2";
            this.sinhvien2.Size = new System.Drawing.Size(1160, 575);
            this.sinhvien2.TabIndex = 2;
            // 
            // sinhvien1
            // 
            this.sinhvien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sinhvien1.BackgroundImage")));
            this.sinhvien1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sinhvien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhvien1.Location = new System.Drawing.Point(0, 0);
            this.sinhvien1.Name = "sinhvien1";
            this.sinhvien1.Size = new System.Drawing.Size(1160, 575);
            this.sinhvien1.TabIndex = 1;
            // 
            // thongtinsinhvien1
            // 
            this.thongtinsinhvien1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thongtinsinhvien1.BackgroundImage")));
            this.thongtinsinhvien1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thongtinsinhvien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongtinsinhvien1.Location = new System.Drawing.Point(0, 0);
            this.thongtinsinhvien1.Name = "thongtinsinhvien1";
            this.thongtinsinhvien1.Size = new System.Drawing.Size(1160, 575);
            this.thongtinsinhvien1.TabIndex = 0;
            // 
            // MainForm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1184, 635);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Student";
            this.Load += new System.EventHandler(this.MainForm_Student_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private Thongtinsinhvien thongtinsinhvien1;
        private sinhvien sinhvien1;
        private sinhvien sinhvien2;
        private System.Windows.Forms.ToolStripMenuItem sinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngKýHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýHọcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem traCứuHọcPhíToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tổngGpaToolStripMenuItem;
    }
}