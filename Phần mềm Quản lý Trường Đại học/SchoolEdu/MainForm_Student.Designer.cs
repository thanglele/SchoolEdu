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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýHọcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhToolStripMenuItem,
            this.toolStripMenuItem1,
            this.thôngTinSinhViênToolStripMenuItem,
            this.đăngKýHọcToolStripMenuItem,
            this.đăngKýHọcToolStripMenuItem1,
            this.traCứuHọcPhíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sinhToolStripMenuItem
            // 
            this.sinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinhToolStripMenuItem.Name = "sinhToolStripMenuItem";
            this.sinhToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.sinhToolStripMenuItem.Text = "Sinh Viên";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 25);
            this.toolStripMenuItem1.Text = "Thông tin sinh viên";
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(12, 25);
            // 
            // đăngKýHọcToolStripMenuItem
            // 
            this.đăngKýHọcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngKýHọcToolStripMenuItem.Name = "đăngKýHọcToolStripMenuItem";
            this.đăngKýHọcToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.đăngKýHọcToolStripMenuItem.Text = "Thông tin lớp học";
            // 
            // đăngKýHọcToolStripMenuItem1
            // 
            this.đăngKýHọcToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngKýHọcToolStripMenuItem1.Name = "đăngKýHọcToolStripMenuItem1";
            this.đăngKýHọcToolStripMenuItem1.Size = new System.Drawing.Size(108, 25);
            this.đăngKýHọcToolStripMenuItem1.Text = "Đăng ký học";
            // 
            // traCứuHọcPhíToolStripMenuItem
            // 
            this.traCứuHọcPhíToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuHọcPhíToolStripMenuItem.Name = "traCứuHọcPhíToolStripMenuItem";
            this.traCứuHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.traCứuHọcPhíToolStripMenuItem.Text = "Tra cứu học phí";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 371);
            this.panel1.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(684, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 36);
            this.logout.TabIndex = 3;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_click);
            // 
            // MainForm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 430);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.student_closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýHọcToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem đăngKýHọcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem traCứuHọcPhíToolStripMenuItem;
        private System.Windows.Forms.Button logout;
    }
}