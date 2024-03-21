
namespace QLSINHVIEN.GUI
{
    partial class frm_Lop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Hủy = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.txt_NienKhoa = new System.Windows.Forms.TextBox();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(99, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 518);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bt_Hủy);
            this.panel1.Controls.Add(this.bt_Reset);
            this.panel1.Controls.Add(this.txt_NienKhoa);
            this.panel1.Controls.Add(this.txt_Khoa);
            this.panel1.Controls.Add(this.txt_MaLop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1187, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 518);
            this.panel1.TabIndex = 2;
            // 
            // bt_Hủy
            // 
            this.bt_Hủy.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Hủy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Hủy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Hủy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Hủy.Location = new System.Drawing.Point(187, 404);
            this.bt_Hủy.Name = "bt_Hủy";
            this.bt_Hủy.Size = new System.Drawing.Size(115, 46);
            this.bt_Hủy.TabIndex = 12;
            this.bt_Hủy.Text = "Hủy";
            this.bt_Hủy.UseVisualStyleBackColor = false;
            this.bt_Hủy.Visible = false;
            this.bt_Hủy.Click += new System.EventHandler(this.bt_Hủy_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Reset.Location = new System.Drawing.Point(20, 404);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(115, 46);
            this.bt_Reset.TabIndex = 11;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Visible = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // txt_NienKhoa
            // 
            this.txt_NienKhoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_NienKhoa.Enabled = false;
            this.txt_NienKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NienKhoa.Location = new System.Drawing.Point(20, 221);
            this.txt_NienKhoa.Name = "txt_NienKhoa";
            this.txt_NienKhoa.Size = new System.Drawing.Size(282, 34);
            this.txt_NienKhoa.TabIndex = 10;
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Khoa.Enabled = false;
            this.txt_Khoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Khoa.Location = new System.Drawing.Point(20, 127);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.Size = new System.Drawing.Size(282, 34);
            this.txt_Khoa.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_MaLop.Enabled = false;
            this.txt_MaLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaLop.Location = new System.Drawing.Point(18, 38);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(284, 34);
            this.txt_MaLop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niên Khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.bt_Luu);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(99, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1434, 106);
            this.panel2.TabIndex = 3;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Xoa.Image = global::QLSINHVIEN.Properties.Resources.icons8_delete_100;
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(1054, 0);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(380, 106);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Sua.Image = global::QLSINHVIEN.Properties.Resources.icons8_pencil_drawing_96;
            this.bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sua.Location = new System.Drawing.Point(768, 0);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(390, 106);
            this.bt_Sua.TabIndex = 2;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Luu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Luu.Image = global::QLSINHVIEN.Properties.Resources.icons8_save_96;
            this.bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Luu.Location = new System.Drawing.Point(389, 0);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(380, 106);
            this.bt_Luu.TabIndex = 1;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Them.Image = global::QLSINHVIEN.Properties.Resources.icons8_add_80;
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Them.Location = new System.Drawing.Point(0, 0);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(390, 106);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // frm_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1571, 782);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Lop";
            this.Text = "frm_Lop";
            this.Load += new System.EventHandler(this.frm_Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Hủy;
        private System.Windows.Forms.Button bt_Reset;
        public System.Windows.Forms.TextBox txt_NienKhoa;
        public System.Windows.Forms.TextBox txt_Khoa;
        public System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Them;
    }
}