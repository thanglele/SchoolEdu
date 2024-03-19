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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.điachi = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.magv = new System.Windows.Forms.Label();
            this.schoolEduDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolEdu_DatabaseDataSet = new SchoolEdu.SchoolEdu_DatabaseDataSet();
            this.schoolEdu_DatabaseDataSet1 = new SchoolEdu.SchoolEdu_DatabaseDataSet();
            this.dataSet41BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet41 = new SchoolEdu.DataSet4();
            this.dataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new SchoolEdu.DataSet4();
            this.dataSet4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.thongtingiaovien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEduDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource1)).BeginInit();
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
            this.thongtingiaovien.Controls.Add(this.xoa);
            this.thongtingiaovien.Controls.Add(this.sua);
            this.thongtingiaovien.Controls.Add(this.them);
            this.thongtingiaovien.Controls.Add(this.dataGridView1);
            this.thongtingiaovien.Controls.Add(this.comboBox1);
            this.thongtingiaovien.Controls.Add(this.điachi);
            this.thongtingiaovien.Controls.Add(this.textBox3);
            this.thongtingiaovien.Controls.Add(this.textBox2);
            this.thongtingiaovien.Controls.Add(this.textBox1);
            this.thongtingiaovien.Controls.Add(this.ngaysinh);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.DataSource = this.dataSet4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataSet4BindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(447, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // điachi
            // 
            this.điachi.AutoSize = true;
            this.điachi.ForeColor = System.Drawing.Color.Fuchsia;
            this.điachi.Location = new System.Drawing.Point(362, 57);
            this.điachi.Name = "điachi";
            this.điachi.Size = new System.Drawing.Size(51, 17);
            this.điachi.TabIndex = 8;
            this.điachi.Text = "Địa chỉ";
            this.điachi.Click += new System.EventHandler(this.điachi_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(449, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 5;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.ForeColor = System.Drawing.Color.Fuchsia;
            this.ngaysinh.Location = new System.Drawing.Point(362, 23);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(71, 17);
            this.ngaysinh.TabIndex = 4;
            this.ngaysinh.Text = "Ngày sinh";
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
            // schoolEduDatabaseDataSetBindingSource
            // 
            this.schoolEduDatabaseDataSetBindingSource.DataSource = this.schoolEdu_DatabaseDataSet;
            this.schoolEduDatabaseDataSetBindingSource.Position = 0;
            // 
            // schoolEdu_DatabaseDataSet
            // 
            this.schoolEdu_DatabaseDataSet.DataSetName = "SchoolEdu_DatabaseDataSet";
            this.schoolEdu_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolEdu_DatabaseDataSet1
            // 
            this.schoolEdu_DatabaseDataSet1.DataSetName = "SchoolEdu_DatabaseDataSet";
            this.schoolEdu_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet41BindingSource
            // 
            this.dataSet41BindingSource.DataSource = this.dataSet41;
            this.dataSet41BindingSource.Position = 0;
            // 
            // dataSet41
            // 
            this.dataSet41.DataSetName = "DataSet4";
            this.dataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet4BindingSource
            // 
            this.dataSet4BindingSource.DataSource = this.dataSet4;
            this.dataSet4BindingSource.Position = 0;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet4BindingSource1
            // 
            this.dataSet4BindingSource1.DataSource = this.dataSet4;
            this.dataSet4BindingSource1.Position = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaGV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(358, 123);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 11;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(447, 123);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 12;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(533, 123);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 13;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.schoolEduDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource schoolEduDatabaseDataSetBindingSource;
        private SchoolEdu_DatabaseDataSet schoolEdu_DatabaseDataSet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.Label magv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label điachi;
        private SchoolEdu_DatabaseDataSet schoolEdu_DatabaseDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet4BindingSource;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource dataSet4BindingSource1;
        private System.Windows.Forms.BindingSource dataSet41BindingSource;
        private DataSet4 dataSet41;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
    }
}