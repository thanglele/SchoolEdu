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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangkyhoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenmon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.hocphan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sVMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolEdu_DatabaseDataSet2 = new SchoolEdu.SchoolEdu_DatabaseDataSet2();
            this.sVMHTableAdapter = new SchoolEdu.SchoolEdu_DatabaseDataSet2TableAdapters.SVMHTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocphan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 301);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMH,
            this.tenmon,
            this.SoTC});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 301);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MaMH
            // 
            this.MaMH.Text = "Mã Môn Học";
            this.MaMH.Width = 91;
            // 
            // tenmon
            // 
            this.tenmon.Text = "Tên Môn Học";
            this.tenmon.Width = 104;
            // 
            // SoTC
            // 
            this.SoTC.Text = "Số TC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hocphan);
            this.panel2.Location = new System.Drawing.Point(531, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 301);
            this.panel2.TabIndex = 1;
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
            this.dataGridView1.Size = new System.Drawing.Size(1153, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            // 
            // ngaybatdauDataGridViewTextBoxColumn
            // 
            this.ngaybatdauDataGridViewTextBoxColumn.DataPropertyName = "Ngaybatdau";
            this.ngaybatdauDataGridViewTextBoxColumn.HeaderText = "Ngaybatdau";
            this.ngaybatdauDataGridViewTextBoxColumn.Name = "ngaybatdauDataGridViewTextBoxColumn";
            // 
            // ngayketthucDataGridViewTextBoxColumn
            // 
            this.ngayketthucDataGridViewTextBoxColumn.DataPropertyName = "Ngayketthuc";
            this.ngayketthucDataGridViewTextBoxColumn.HeaderText = "Ngayketthuc";
            this.ngayketthucDataGridViewTextBoxColumn.Name = "ngayketthucDataGridViewTextBoxColumn";
            // 
            // soTCDataGridViewTextBoxColumn
            // 
            this.soTCDataGridViewTextBoxColumn.DataPropertyName = "SoTC";
            this.soTCDataGridViewTextBoxColumn.HeaderText = "SoTC";
            this.soTCDataGridViewTextBoxColumn.Name = "soTCDataGridViewTextBoxColumn";
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hocphan)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolEdu_DatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaMH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader tenmon;
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
        private System.Windows.Forms.ColumnHeader SoTC;
    }
}
