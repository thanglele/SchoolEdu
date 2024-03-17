namespace SchoolEdu
{
    partial class MainForm_Teacher
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
            this.Panel_header = new System.Windows.Forms.Panel();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.User_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Main = new System.Windows.Forms.TabControl();
            this.User_Information = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Change_Password = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Old_Password = new System.Windows.Forms.TextBox();
            this.New_Password = new System.Windows.Forms.TextBox();
            this.Recover_New_Password = new System.Windows.Forms.TextBox();
            this.Button_change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_header.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.Main.SuspendLayout();
            this.Change_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_header
            // 
            this.Panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_header.Controls.Add(this.menuStrip1);
            this.Panel_header.Controls.Add(this.toolStripContainer1);
            this.Panel_header.Location = new System.Drawing.Point(0, 0);
            this.Panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_header.Name = "Panel_header";
            this.Panel_header.Size = new System.Drawing.Size(1186, 50);
            this.Panel_header.TabIndex = 0;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Menu_Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Menu_Panel.Location = new System.Drawing.Point(0, 50);
            this.Menu_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(200, 590);
            this.Menu_Panel.TabIndex = 1;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Main_Panel.Controls.Add(this.Main);
            this.Main_Panel.Location = new System.Drawing.Point(200, 50);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(986, 587);
            this.Main_Panel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.User_menu});
            this.menuStrip1.Location = new System.Drawing.Point(852, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(198, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // User_menu
            // 
            this.User_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.User_menu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.User_menu.MergeIndex = 0;
            this.User_menu.Name = "User_menu";
            this.User_menu.Size = new System.Drawing.Size(70, 20);
            this.User_menu.Text = "Họ và tên";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(1022, 12);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Main
            // 
            this.Main.Controls.Add(this.User_Information);
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Controls.Add(this.tabPage3);
            this.Main.Controls.Add(this.tabPage4);
            this.Main.Controls.Add(this.tabPage5);
            this.Main.Controls.Add(this.tabPage6);
            this.Main.Controls.Add(this.Change_Password);
            this.Main.Location = new System.Drawing.Point(3, 3);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(983, 584);
            this.Main.TabIndex = 0;
            // 
            // User_Information
            // 
            this.User_Information.Location = new System.Drawing.Point(4, 22);
            this.User_Information.Name = "User_Information";
            this.User_Information.Padding = new System.Windows.Forms.Padding(3);
            this.User_Information.Size = new System.Drawing.Size(975, 558);
            this.User_Information.TabIndex = 0;
            this.User_Information.Text = "Thông tin tài khoản";
            this.User_Information.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách lớp đang chủ nhiệm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(975, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý đào tạo chủ nhiệm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(975, 558);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Điểm tổng hợp SV";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(975, 558);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kết quả đăng ký học SV";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(975, 558);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Quản lý đào tạo";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Change_Password
            // 
            this.Change_Password.Controls.Add(this.label4);
            this.Change_Password.Controls.Add(this.Button_change);
            this.Change_Password.Controls.Add(this.Recover_New_Password);
            this.Change_Password.Controls.Add(this.New_Password);
            this.Change_Password.Controls.Add(this.Old_Password);
            this.Change_Password.Controls.Add(this.label3);
            this.Change_Password.Controls.Add(this.label2);
            this.Change_Password.Controls.Add(this.label1);
            this.Change_Password.Location = new System.Drawing.Point(4, 22);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Padding = new System.Windows.Forms.Padding(3);
            this.Change_Password.Size = new System.Drawing.Size(975, 558);
            this.Change_Password.TabIndex = 6;
            this.Change_Password.Text = "Đổi mật khẩu";
            this.Change_Password.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(181, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(181, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(181, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // Old_Password
            // 
            this.Old_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Old_Password.Location = new System.Drawing.Point(420, 209);
            this.Old_Password.Name = "Old_Password";
            this.Old_Password.PasswordChar = '*';
            this.Old_Password.Size = new System.Drawing.Size(228, 29);
            this.Old_Password.TabIndex = 3;
            this.Old_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Old_Password_KeyPress);
            // 
            // New_Password
            // 
            this.New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.New_Password.Location = new System.Drawing.Point(420, 255);
            this.New_Password.Name = "New_Password";
            this.New_Password.PasswordChar = '*';
            this.New_Password.Size = new System.Drawing.Size(228, 29);
            this.New_Password.TabIndex = 4;
            this.New_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.New_Password_KeyPress);
            // 
            // Recover_New_Password
            // 
            this.Recover_New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Recover_New_Password.Location = new System.Drawing.Point(420, 309);
            this.Recover_New_Password.Name = "Recover_New_Password";
            this.Recover_New_Password.PasswordChar = '*';
            this.Recover_New_Password.Size = new System.Drawing.Size(228, 29);
            this.Recover_New_Password.TabIndex = 5;
            this.Recover_New_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recover_New_Password_KeyPress);
            // 
            // Button_change
            // 
            this.Button_change.Location = new System.Drawing.Point(604, 394);
            this.Button_change.Name = "Button_change";
            this.Button_change.Size = new System.Drawing.Size(111, 41);
            this.Button_change.TabIndex = 6;
            this.Button_change.Text = "Đổi mật khẩu";
            this.Button_change.UseVisualStyleBackColor = true;
            this.Button_change.Click += new System.EventHandler(this.Button_change_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(327, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thay đổi mật khẩu đăng nhập hệ thống";
            // 
            // MainForm_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 635);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Panel_header);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm_Teacher";
            this.Text = "MainForm_Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Teacher_FormClosing);
            this.Panel_header.ResumeLayout(false);
            this.Panel_header.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Change_Password.ResumeLayout(false);
            this.Change_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_header;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem User_menu;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage User_Information;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage Change_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Recover_New_Password;
        private System.Windows.Forms.TextBox New_Password;
        private System.Windows.Forms.TextBox Old_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_change;
    }
}