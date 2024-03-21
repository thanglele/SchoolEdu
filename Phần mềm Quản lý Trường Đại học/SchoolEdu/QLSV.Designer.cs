
namespace SchoolEdu
{
    partial class QLSV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntk = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.dataSet20BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet20 = new SchoolEdu.DataSet2();
            this.sqlCommand10 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dataSet10 = new SchoolEdu.DataSet1();
            this.dataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolEdu_DatabaseDataSet = new SchoolEdu.SchoolEdu_DatabaseDataSet();
            this.schoolEduDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet20BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEduDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.txtNganh);
            this.panel1.Controls.Add(this.txtLop);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.txtTenSV);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btntk);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 225);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(450, 27);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbGioiTinh.TabIndex = 18;
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(688, 18);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(100, 22);
            this.txtNganh.TabIndex = 17;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(447, 135);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 22);
            this.txtLop.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(447, 81);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(113, 21);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(203, 22);
            this.txtMaSV.TabIndex = 13;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(113, 81);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(203, 22);
            this.txtTenSV.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "TenSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "MaSV";
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(632, 193);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(104, 23);
            this.btntk.TabIndex = 3;
            this.btntk.Text = "Tìm Kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(464, 193);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(277, 193);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(113, 193);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AutoGenerateColumns = false;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.DataSource = this.dataSet20BindingSource;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(0, 223);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 51;
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(801, 231);
            this.dataGridViewSinhVien.TabIndex = 1;
            this.dataGridViewSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet20BindingSource
            // 
            this.dataSet20BindingSource.DataSource = this.dataSet20;
            this.dataSet20BindingSource.Position = 0;
            // 
            // dataSet20
            // 
            this.dataSet20.DataSetName = "DataSet20";
            this.dataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlCommand10
            // 
            this.sqlCommand10.CommandTimeout = 30;
            this.sqlCommand10.EnableOptimizedParameterBinding = false;
            // 
            // dataSet10
            // 
            this.dataSet10.DataSetName = "DataSet10";
            this.dataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet10BindingSource
            // 
            this.dataSet10BindingSource.DataSource = this.dataSet10;
            this.dataSet10BindingSource.Position = 0;
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
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.panel1);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.QLSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet20BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEduDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Windows.Forms.BindingSource dataSet10BindingSource;
        private DataSet1 dataSet10;
        private System.Windows.Forms.BindingSource dataSet20BindingSource;
        private DataSet2 dataSet20;
        private SchoolEdu_DatabaseDataSet schoolEdu_DatabaseDataSet;
        private System.Windows.Forms.BindingSource schoolEduDatabaseDataSetBindingSource;
    }
}