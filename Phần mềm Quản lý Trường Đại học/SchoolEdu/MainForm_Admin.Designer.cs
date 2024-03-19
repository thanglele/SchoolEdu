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
            this.components = new System.ComponentModel.Container();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.quanlyhocvu = new System.Windows.Forms.TabPage();
            this.thongtingiaovien = new System.Windows.Forms.TabPage();
            this.magv = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolEdu_DatabaseDataSet = new SchoolEdu.SchoolEdu_DatabaseDataSet();
            this.schoolEduDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.thongtingiaovien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEduDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.thoat);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 55);
            this.panel1.TabIndex = 0;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(715, 27);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 3;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(2, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 396);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(125, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 393);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(661, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.quanlyhocvu);
            this.tabControl2.Controls.Add(this.thongtingiaovien);
            this.tabControl2.Location = new System.Drawing.Point(72, 57);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(724, 393);
            this.tabControl2.TabIndex = 2;
            // 
            // quanlyhocvu
            // 
            this.quanlyhocvu.Location = new System.Drawing.Point(4, 25);
            this.quanlyhocvu.Name = "quanlyhocvu";
            this.quanlyhocvu.Padding = new System.Windows.Forms.Padding(3);
            this.quanlyhocvu.Size = new System.Drawing.Size(716, 364);
            this.quanlyhocvu.TabIndex = 0;
            this.quanlyhocvu.Text = "Quản lý học vụ sinh viên";
            this.quanlyhocvu.UseVisualStyleBackColor = true;
            // 
            // thongtingiaovien
            // 
            this.thongtingiaovien.Controls.Add(this.dataGridView1);
            this.thongtingiaovien.Controls.Add(this.textBox3);
            this.thongtingiaovien.Controls.Add(this.textBox2);
            this.thongtingiaovien.Controls.Add(this.textBox1);
            this.thongtingiaovien.Controls.Add(this.sdt);
            this.thongtingiaovien.Controls.Add(this.hoten);
            this.thongtingiaovien.Controls.Add(this.magv);
            this.thongtingiaovien.Location = new System.Drawing.Point(4, 25);
            this.thongtingiaovien.Name = "thongtingiaovien";
            this.thongtingiaovien.Padding = new System.Windows.Forms.Padding(3);
            this.thongtingiaovien.Size = new System.Drawing.Size(716, 364);
            this.thongtingiaovien.TabIndex = 1;
            this.thongtingiaovien.Text = "Thông tin giáo viên";
            this.thongtingiaovien.UseVisualStyleBackColor = true;
            // 
            // magv
            // 
            this.magv.AutoSize = true;
            this.magv.ForeColor = System.Drawing.Color.Fuchsia;
            this.magv.Location = new System.Drawing.Point(34, 23);
            this.magv.Name = "magv";
            this.magv.Size = new System.Drawing.Size(47, 17);
            this.magv.TabIndex = 0;
            this.magv.Text = "MaGV";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.ForeColor = System.Drawing.Color.Fuchsia;
            this.hoten.Location = new System.Drawing.Point(34, 58);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(93, 17);
            this.hoten.TabIndex = 3;
            this.hoten.Text = "Họ và tên GV";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.ForeColor = System.Drawing.Color.Fuchsia;
            this.sdt.Location = new System.Drawing.Point(395, 23);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(36, 17);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "SĐT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(449, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 22);
            this.textBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.schoolEduDatabaseDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // schoolEdu_DatabaseDataSet
            // 
            this.schoolEdu_DatabaseDataSet.DataSetName = "SchoolEdu_DatabaseDataSet";
            this.schoolEdu_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolEduDatabaseDataSetBindingSource
            // 
            this.schoolEduDatabaseDataSetBindingSource.DataSource = this.schoolEdu_DatabaseDataSet;
            this.schoolEduDatabaseDataSetBindingSource.Position = 0;
            // 
            // MainForm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm_Admin";
            this.Text = "MainForm_Admin";
            this.Load += new System.EventHandler(this.MainForm_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.thongtingiaovien.ResumeLayout(false);
            this.thongtingiaovien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEduDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage quanlyhocvu;
        private System.Windows.Forms.TabPage thongtingiaovien;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource schoolEduDatabaseDataSetBindingSource;
        private SchoolEdu_DatabaseDataSet schoolEdu_DatabaseDataSet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.Label magv;
    }
}