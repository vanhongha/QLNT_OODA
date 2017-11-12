namespace QLNT.Presentation
{
    partial class frmThongTinSucKhoe
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.dgvSucKhoe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm học";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(90, 12);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(160, 21);
            this.cboNamHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tháng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sỉ số";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboLoaiLop
            // 
            this.cboLoaiLop.FormattingEnabled = true;
            this.cboLoaiLop.Location = new System.Drawing.Point(90, 46);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(160, 21);
            this.cboLoaiLop.TabIndex = 1;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(90, 81);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(160, 21);
            this.cboLop.TabIndex = 1;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(351, 9);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(60, 21);
            this.cboThang.TabIndex = 1;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(351, 43);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(60, 20);
            this.txtSiSo.TabIndex = 2;
            // 
            // dgvSucKhoe
            // 
            this.dgvSucKhoe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSucKhoe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucKhoe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSucKhoe.Location = new System.Drawing.Point(0, 0);
            this.dgvSucKhoe.Name = "dgvSucKhoe";
            this.dgvSucKhoe.Size = new System.Drawing.Size(1077, 636);
            this.dgvSucKhoe.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLoaiLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSiSo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboThang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboLop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboNamHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 115);
            this.panel1.TabIndex = 4;
            // 
            // frmThongTinSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSucKhoe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinSucKhoe";
            this.Text = "frmThongTinSucKhoe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.DataGridView dgvSucKhoe;
        private System.Windows.Forms.Panel panel1;
    }
}