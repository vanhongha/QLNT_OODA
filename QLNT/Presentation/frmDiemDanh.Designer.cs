namespace QLNT.Presentation
{
    partial class frmDiemDanh
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
            this.btnTaoBangMoi = new System.Windows.Forms.Button();
            this.btnLuuDiemDanh = new System.Windows.Forms.Button();
            this.dtNgayDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChonLop = new System.Windows.Forms.GroupBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.dgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.grpChonLop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoBangMoi
            // 
            this.btnTaoBangMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBangMoi.Location = new System.Drawing.Point(617, 223);
            this.btnTaoBangMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoBangMoi.Name = "btnTaoBangMoi";
            this.btnTaoBangMoi.Size = new System.Drawing.Size(120, 50);
            this.btnTaoBangMoi.TabIndex = 17;
            this.btnTaoBangMoi.Text = "Tạo bảng mới hôm nay";
            this.btnTaoBangMoi.UseVisualStyleBackColor = true;
            this.btnTaoBangMoi.Click += new System.EventHandler(this.btnTaoBangMoi_Click);
            // 
            // btnLuuDiemDanh
            // 
            this.btnLuuDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDiemDanh.Location = new System.Drawing.Point(745, 223);
            this.btnLuuDiemDanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuDiemDanh.Name = "btnLuuDiemDanh";
            this.btnLuuDiemDanh.Size = new System.Drawing.Size(120, 50);
            this.btnLuuDiemDanh.TabIndex = 16;
            this.btnLuuDiemDanh.Text = "Lưu bảng điểm danh";
            this.btnLuuDiemDanh.UseVisualStyleBackColor = true;
            this.btnLuuDiemDanh.Click += new System.EventHandler(this.btnLuuDiemDanh_Click);
            // 
            // dtNgayDiemDanh
            // 
            this.dtNgayDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDiemDanh.Location = new System.Drawing.Point(695, 162);
            this.dtNgayDiemDanh.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayDiemDanh.Name = "dtNgayDiemDanh";
            this.dtNgayDiemDanh.Size = new System.Drawing.Size(170, 22);
            this.dtNgayDiemDanh.TabIndex = 4;
            this.dtNgayDiemDanh.ValueChanged += new System.EventHandler(this.dtNgayDiemDanh_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày :";
            // 
            // grpChonLop
            // 
            this.grpChonLop.Controls.Add(this.cboNamHoc);
            this.grpChonLop.Controls.Add(this.cboLop);
            this.grpChonLop.Controls.Add(this.label3);
            this.grpChonLop.Controls.Add(this.label1);
            this.grpChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChonLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpChonLop.Location = new System.Drawing.Point(610, 45);
            this.grpChonLop.Name = "grpChonLop";
            this.grpChonLop.Size = new System.Drawing.Size(266, 103);
            this.grpChonLop.TabIndex = 14;
            this.grpChonLop.TabStop = false;
            this.grpChonLop.Text = "Chọn lớp";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(85, 26);
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
            this.cboLop.Location = new System.Drawing.Point(85, 55);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(170, 24);
            this.cboLop.TabIndex = 10;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm học:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.dtNgayDiemDanh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTaoBangMoi);
            this.panel2.Controls.Add(this.btnLuuDiemDanh);
            this.panel2.Controls.Add(this.lbThongBao);
            this.panel2.Controls.Add(this.dgvDiemDanh);
            this.panel2.Controls.Add(this.grpChonLop);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 545);
            this.panel2.TabIndex = 3;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(614, 292);
            this.lbThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(77, 16);
            this.lbThongBao.TabIndex = 1;
            this.lbThongBao.Text = "Thông báo:";
            this.lbThongBao.Visible = false;
            // 
            // dgvDiemDanh
            // 
            this.dgvDiemDanh.AllowUserToAddRows = false;
            this.dgvDiemDanh.AllowUserToDeleteRows = false;
            this.dgvDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDanh.Location = new System.Drawing.Point(12, 45);
            this.dgvDiemDanh.Name = "dgvDiemDanh";
            this.dgvDiemDanh.Size = new System.Drawing.Size(553, 463);
            this.dgvDiemDanh.TabIndex = 0;
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 545);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiemDanh";
            this.Text = "frmDiemDanh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.grpChonLop.ResumeLayout(false);
            this.grpChonLop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpChonLop;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDiemDanh;
        private System.Windows.Forms.DateTimePicker dtNgayDiemDanh;
        private System.Windows.Forms.Button btnLuuDiemDanh;
        private System.Windows.Forms.Button btnTaoBangMoi;
        private System.Windows.Forms.Label lbThongBao;
    }
}