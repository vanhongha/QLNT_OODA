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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuuDiemDanh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChonLop = new System.Windows.Forms.GroupBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.btnTaoBangMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpChonLop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaoBangMoi);
            this.panel1.Controls.Add(this.btnLuuDiemDanh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpChonLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 158);
            this.panel1.TabIndex = 2;
            // 
            // btnLuuDiemDanh
            // 
            this.btnLuuDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLuuDiemDanh.Location = new System.Drawing.Point(973, 31);
            this.btnLuuDiemDanh.Name = "btnLuuDiemDanh";
            this.btnLuuDiemDanh.Size = new System.Drawing.Size(125, 109);
            this.btnLuuDiemDanh.TabIndex = 16;
            this.btnLuuDiemDanh.Text = "Lưu bảng điểm danh";
            this.btnLuuDiemDanh.UseVisualStyleBackColor = true;
            this.btnLuuDiemDanh.Click += new System.EventHandler(this.btnLuuDiemDanh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayDiemDanh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(417, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 127);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày điểm danh";
            // 
            // dtNgayDiemDanh
            // 
            this.dtNgayDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtNgayDiemDanh.Location = new System.Drawing.Point(78, 47);
            this.dtNgayDiemDanh.Name = "dtNgayDiemDanh";
            this.dtNgayDiemDanh.Size = new System.Drawing.Size(272, 30);
            this.dtNgayDiemDanh.TabIndex = 4;
            this.dtNgayDiemDanh.ValueChanged += new System.EventHandler(this.dtNgayDiemDanh_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày ";
            // 
            // grpChonLop
            // 
            this.grpChonLop.Controls.Add(this.cboNamHoc);
            this.grpChonLop.Controls.Add(this.cboLop);
            this.grpChonLop.Controls.Add(this.label3);
            this.grpChonLop.Controls.Add(this.label1);
            this.grpChonLop.Location = new System.Drawing.Point(13, 13);
            this.grpChonLop.Margin = new System.Windows.Forms.Padding(4);
            this.grpChonLop.Name = "grpChonLop";
            this.grpChonLop.Padding = new System.Windows.Forms.Padding(4);
            this.grpChonLop.Size = new System.Drawing.Size(379, 127);
            this.grpChonLop.TabIndex = 14;
            this.grpChonLop.TabStop = false;
            this.grpChonLop.Text = "Chọn lớp";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(113, 30);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(256, 33);
            this.cboNamHoc.TabIndex = 11;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(113, 71);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(256, 33);
            this.cboLop.TabIndex = 10;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDiemDanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 671);
            this.panel2.TabIndex = 3;
            // 
            // dgvDiemDanh
            // 
            this.dgvDiemDanh.AllowUserToAddRows = false;
            this.dgvDiemDanh.AllowUserToDeleteRows = false;
            this.dgvDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDanh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDiemDanh.Location = new System.Drawing.Point(0, 166);
            this.dgvDiemDanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiemDanh.Name = "dgvDiemDanh";
            this.dgvDiemDanh.Size = new System.Drawing.Size(1157, 505);
            this.dgvDiemDanh.TabIndex = 0;
            // 
            // btnTaoBangMoi
            // 
            this.btnTaoBangMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTaoBangMoi.Location = new System.Drawing.Point(809, 31);
            this.btnTaoBangMoi.Name = "btnTaoBangMoi";
            this.btnTaoBangMoi.Size = new System.Drawing.Size(125, 109);
            this.btnTaoBangMoi.TabIndex = 17;
            this.btnTaoBangMoi.Text = "Tạo bảng mới hôm nay";
            this.btnTaoBangMoi.UseVisualStyleBackColor = true;
            this.btnTaoBangMoi.Click += new System.EventHandler(this.btnTaoBangMoi_Click);
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiemDanh";
            this.Text = "frmDiemDanh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpChonLop.ResumeLayout(false);
            this.grpChonLop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}