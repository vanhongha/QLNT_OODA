namespace QLNT.Presentation
{
    partial class frmPhieuBeNgoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuBeNgoan));
            this.btnTaoPhieuMoi = new System.Windows.Forms.Button();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.dtThangLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChonLop = new System.Windows.Forms.GroupBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.dgvPhieuBeNgoan = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpChonLop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBeNgoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoPhieuMoi
            // 
            this.btnTaoPhieuMoi.Enabled = false;
            this.btnTaoPhieuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuMoi.Location = new System.Drawing.Point(874, 199);
            this.btnTaoPhieuMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoPhieuMoi.Name = "btnTaoPhieuMoi";
            this.btnTaoPhieuMoi.Size = new System.Drawing.Size(120, 50);
            this.btnTaoPhieuMoi.TabIndex = 17;
            this.btnTaoPhieuMoi.Text = "Tạo phiếu tháng này";
            this.btnTaoPhieuMoi.UseVisualStyleBackColor = true;
            this.btnTaoPhieuMoi.Click += new System.EventHandler(this.btnTaoPhieuMoi_Click);
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Enabled = false;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieu.Location = new System.Drawing.Point(997, 199);
            this.btnLuuPhieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(120, 50);
            this.btnLuuPhieu.TabIndex = 16;
            this.btnLuuPhieu.Text = "Lưu phiếu tháng này";
            this.btnLuuPhieu.UseVisualStyleBackColor = true;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // dtThangLapPhieu
            // 
            this.dtThangLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThangLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtThangLapPhieu.Location = new System.Drawing.Point(933, 156);
            this.dtThangLapPhieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtThangLapPhieu.Name = "dtThangLapPhieu";
            this.dtThangLapPhieu.Size = new System.Drawing.Size(170, 22);
            this.dtThangLapPhieu.TabIndex = 4;
            this.dtThangLapPhieu.ValueChanged += new System.EventHandler(this.dtThangLapPhieu_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(883, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày ";
            // 
            // grpChonLop
            // 
            this.grpChonLop.Controls.Add(this.cboNamHoc);
            this.grpChonLop.Controls.Add(this.cboLop);
            this.grpChonLop.Controls.Add(this.label3);
            this.grpChonLop.Controls.Add(this.label1);
            this.grpChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChonLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpChonLop.Location = new System.Drawing.Point(847, 39);
            this.grpChonLop.Name = "grpChonLop";
            this.grpChonLop.Size = new System.Drawing.Size(284, 103);
            this.grpChonLop.TabIndex = 14;
            this.grpChonLop.TabStop = false;
            this.grpChonLop.Text = "Chọn lớp";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(85, 24);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(170, 24);
            this.cboNamHoc.TabIndex = 11;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(85, 58);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(170, 24);
            this.cboLop.TabIndex = 10;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnTaoPhieuMoi);
            this.panel2.Controls.Add(this.btnLuuPhieu);
            this.panel2.Controls.Add(this.dtThangLapPhieu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbThongBao);
            this.panel2.Controls.Add(this.dgvPhieuBeNgoan);
            this.panel2.Controls.Add(this.grpChonLop);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 517);
            this.panel2.TabIndex = 5;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(870, 251);
            this.lbThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(77, 16);
            this.lbThongBao.TabIndex = 1;
            this.lbThongBao.Text = "Thông báo:";
            this.lbThongBao.Visible = false;
            // 
            // dgvPhieuBeNgoan
            // 
            this.dgvPhieuBeNgoan.AllowUserToAddRows = false;
            this.dgvPhieuBeNgoan.AllowUserToDeleteRows = false;
            this.dgvPhieuBeNgoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhieuBeNgoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuBeNgoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuBeNgoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuBeNgoan.Location = new System.Drawing.Point(10, 11);
            this.dgvPhieuBeNgoan.Name = "dgvPhieuBeNgoan";
            this.dgvPhieuBeNgoan.RowHeadersVisible = false;
            this.dgvPhieuBeNgoan.Size = new System.Drawing.Size(820, 496);
            this.dgvPhieuBeNgoan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(864, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 207);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(993, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 207);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // frmPhieuBeNgoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 529);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuBeNgoan";
            this.Text = "frmPhieuBeNgoan";
            this.Load += new System.EventHandler(this.frmPhieuBeNgoan_Load);
            this.grpChonLop.ResumeLayout(false);
            this.grpChonLop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBeNgoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTaoPhieuMoi;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.DateTimePicker dtThangLapPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpChonLop;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPhieuBeNgoan;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}