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
            this.SuspendLayout();
            // 
            // Panel_header
            // 
            this.Panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_header.Location = new System.Drawing.Point(0, 0);
            this.Panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_header.Name = "Panel_header";
            this.Panel_header.Size = new System.Drawing.Size(1186, 50);
            this.Panel_header.TabIndex = 0;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Menu_Panel.Location = new System.Drawing.Point(0, 50);
            this.Menu_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(200, 590);
            this.Menu_Panel.TabIndex = 1;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Main_Panel.Location = new System.Drawing.Point(200, 50);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(986, 587);
            this.Main_Panel.TabIndex = 2;
            // 
            // MainForm_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 635);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Panel_header);
            this.Name = "MainForm_Teacher";
            this.Text = "MainForm_Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Teacher_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_header;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Panel Main_Panel;
    }
}