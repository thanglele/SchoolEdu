namespace SchoolEdu
{
    partial class dangkyhoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangkyhoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maMHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTCDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolEdu_DatabaseDataSet4 = new SchoolEdu.SchoolEdu_DatabaseDataSet4();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMHDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonghocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gVMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolEdu_DatabaseDataSet5 = new SchoolEdu.SchoolEdu_DatabaseDataSet5();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.hocphan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mONHOCTableAdapter = new SchoolEdu.SchoolEdu_DatabaseDataSet4TableAdapters.MONHOCTableAdapter();
            this.gVMHTableAdapter = new SchoolEdu.SchoolEdu_DatabaseDataSet5TableAdapters.GVMHTableAdapter();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sVMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolEdu_DatabaseDataSet2 = new SchoolEdu.SchoolEdu_DatabaseDataSet2();
            this.sVMHTableAdapter = new SchoolEdu.SchoolEdu_DatabaseDataSet2TableAdapters.SVMHTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocphan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 301);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMHDataGridViewTextBoxColumn1,
            this.tenMHDataGridViewTextBoxColumn,
            this.soTCDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.mONHOCBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(521, 301);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.monhoc_celldoubleclick);
            // 
            // maMHDataGridViewTextBoxColumn1
            // 
            this.maMHDataGridViewTextBoxColumn1.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn1.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn1.Name = "maMHDataGridViewTextBoxColumn1";
            this.maMHDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenMHDataGridViewTextBoxColumn
            // 
            this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.HeaderText = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
            this.tenMHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTCDataGridViewTextBoxColumn1
            // 
            this.soTCDataGridViewTextBoxColumn1.DataPropertyName = "SoTC";
            this.soTCDataGridViewTextBoxColumn1.HeaderText = "SoTC";
            this.soTCDataGridViewTextBoxColumn1.Name = "soTCDataGridViewTextBoxColumn1";
            this.soTCDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.schoolEdu_DatabaseDataSet4;
            // 
            // schoolEdu_DatabaseDataSet4
            // 
            this.schoolEdu_DatabaseDataSet4.DataSetName = "SchoolEdu_DatabaseDataSet4";
            this.schoolEdu_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.hocphan);
            this.panel2.Location = new System.Drawing.Point(531, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 301);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGVDataGridViewTextBoxColumn,
            this.maMHDataGridViewTextBoxColumn2,
            this.ngaybdDataGridViewTextBoxColumn,
            this.phonghocDataGridViewTextBoxColumn,
            this.caHocDataGridViewTextBoxColumn,
            this.ngayktDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.gVMHBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(616, 301);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_MH_celldoubleclick);
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMHDataGridViewTextBoxColumn2
            // 
            this.maMHDataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn2.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn2.Name = "maMHDataGridViewTextBoxColumn2";
            this.maMHDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ngaybdDataGridViewTextBoxColumn
            // 
            this.ngaybdDataGridViewTextBoxColumn.DataPropertyName = "Ngaybd";
            this.ngaybdDataGridViewTextBoxColumn.HeaderText = "Ngaybd";
            this.ngaybdDataGridViewTextBoxColumn.Name = "ngaybdDataGridViewTextBoxColumn";
            this.ngaybdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonghocDataGridViewTextBoxColumn
            // 
            this.phonghocDataGridViewTextBoxColumn.DataPropertyName = "Phonghoc";
            this.phonghocDataGridViewTextBoxColumn.HeaderText = "Phonghoc";
            this.phonghocDataGridViewTextBoxColumn.Name = "phonghocDataGridViewTextBoxColumn";
            this.phonghocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caHocDataGridViewTextBoxColumn
            // 
            this.caHocDataGridViewTextBoxColumn.DataPropertyName = "CaHoc";
            this.caHocDataGridViewTextBoxColumn.HeaderText = "CaHoc";
            this.caHocDataGridViewTextBoxColumn.Name = "caHocDataGridViewTextBoxColumn";
            this.caHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayktDataGridViewTextBoxColumn
            // 
            this.ngayktDataGridViewTextBoxColumn.DataPropertyName = "Ngaykt";
            this.ngayktDataGridViewTextBoxColumn.HeaderText = "Ngaykt";
            this.ngayktDataGridViewTextBoxColumn.Name = "ngayktDataGridViewTextBoxColumn";
            this.ngayktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gVMHBindingSource
            // 
            this.gVMHBindingSource.DataMember = "GVMH";
            this.gVMHBindingSource.DataSource = this.schoolEdu_DatabaseDataSet5;
            // 
            // schoolEdu_DatabaseDataSet5
            // 
            this.schoolEdu_DatabaseDataSet5.DataSetName = "SchoolEdu_DatabaseDataSet5";
            this.schoolEdu_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(616, 301);
            this.dataGridView3.TabIndex = 1;
            // 
            // hocphan
            // 
            this.hocphan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hocphan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hocphan.Location = new System.Drawing.Point(0, 0);
            this.hocphan.Name = "hocphan";
            this.hocphan.Size = new System.Drawing.Size(616, 301);
            this.hocphan.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(4, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1153, 261);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.maMHDataGridViewTextBoxColumn,
            this.ngaybatdauDataGridViewTextBoxColumn,
            this.ngayketthucDataGridViewTextBoxColumn,
            this.soTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sVMHBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gVMHTableAdapter
            // 
            this.gVMHTableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            this.maMHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaybatdauDataGridViewTextBoxColumn
            // 
            this.ngaybatdauDataGridViewTextBoxColumn.DataPropertyName = "Ngaybatdau";
            this.ngaybatdauDataGridViewTextBoxColumn.HeaderText = "Ngaybatdau";
            this.ngaybatdauDataGridViewTextBoxColumn.Name = "ngaybatdauDataGridViewTextBoxColumn";
            this.ngaybatdauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayketthucDataGridViewTextBoxColumn
            // 
            this.ngayketthucDataGridViewTextBoxColumn.DataPropertyName = "Ngayketthuc";
            this.ngayketthucDataGridViewTextBoxColumn.HeaderText = "Ngayketthuc";
            this.ngayketthucDataGridViewTextBoxColumn.Name = "ngayketthucDataGridViewTextBoxColumn";
            this.ngayketthucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTCDataGridViewTextBoxColumn
            // 
            this.soTCDataGridViewTextBoxColumn.DataPropertyName = "SoTC";
            this.soTCDataGridViewTextBoxColumn.HeaderText = "SoTC";
            this.soTCDataGridViewTextBoxColumn.Name = "soTCDataGridViewTextBoxColumn";
            this.soTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sVMHBindingSource
            // 
            this.sVMHBindingSource.DataMember = "SVMH";
            this.sVMHBindingSource.DataSource = this.schoolEdu_DatabaseDataSet2;
            // 
            // schoolEdu_DatabaseDataSet2
            // 
            this.schoolEdu_DatabaseDataSet2.DataSetName = "SchoolEdu_DatabaseDataSet2";
            this.schoolEdu_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sVMHTableAdapter
            // 
            this.sVMHTableAdapter.ClearBeforeFill = true;
            // 
            // dangkyhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "dangkyhoc";
            this.Size = new System.Drawing.Size(1160, 575);
            this.Load += new System.EventHandler(this.dangkyhoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocphan)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView hocphan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sVMHBindingSource;
        private SchoolEdu_DatabaseDataSet2 schoolEdu_DatabaseDataSet2;
        private SchoolEdu_DatabaseDataSet2TableAdapters.SVMHTableAdapter sVMHTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTCDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private SchoolEdu_DatabaseDataSet4 schoolEdu_DatabaseDataSet4;
        private SchoolEdu_DatabaseDataSet4TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonghocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gVMHBindingSource;
        private SchoolEdu_DatabaseDataSet5 schoolEdu_DatabaseDataSet5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private SchoolEdu_DatabaseDataSet5TableAdapters.GVMHTableAdapter gVMHTableAdapter;
    }
}
