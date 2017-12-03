namespace QLNT.Presentation
{
    partial class frmDinhDuong_ThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtMaThucDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.btnLuuChiTiet = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnReloadMonAn = new System.Windows.Forms.Button();
            this.txtMaThucDon2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvChiTietThucDon = new System.Windows.Forms.DataGridView();
            this.cboMonAn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AllowUserToDeleteRows = false;
            this.dgvThucDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Location = new System.Drawing.Point(6, 50);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(595, 265);
            this.dgvThucDon.TabIndex = 45;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNguoiLap);
            this.groupBox2.Controls.Add(this.txtMaThucDon);
            this.groupBox2.Controls.Add(this.dgvThucDon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 490);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(310, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 34);
            this.btnXoa.TabIndex = 107;
            this.btnXoa.Text = "Xóa thực đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(178, 421);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 34);
            this.btnLuu.TabIndex = 106;
            this.btnLuu.Text = "Thêm thực đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(31, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(477, 16);
            this.label15.TabIndex = 73;
            this.label15.Text = "Chọn một THỰC ĐƠN trong bảng để xem chi tiết, áp dụng thực đơn,...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 72;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Enabled = false;
            this.txtNguoiLap.Location = new System.Drawing.Point(203, 377);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(209, 22);
            this.txtNguoiLap.TabIndex = 71;
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.Enabled = false;
            this.txtMaThucDon.Location = new System.Drawing.Point(203, 349);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(209, 22);
            this.txtMaThucDon.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(86, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã thực đơn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(87, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Người lập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaChiTiet);
            this.groupBox1.Controls.Add(this.btnLuuChiTiet);
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.btnReloadMonAn);
            this.groupBox1.Controls.Add(this.txtMaThucDon2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvChiTietThucDon);
            this.groupBox1.Controls.Add(this.cboMonAn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(625, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 490);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT THỰC ĐƠN";
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Location = new System.Drawing.Point(315, 420);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(102, 34);
            this.btnXoaChiTiet.TabIndex = 110;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnLuuChiTiet
            // 
            this.btnLuuChiTiet.Location = new System.Drawing.Point(207, 420);
            this.btnLuuChiTiet.Name = "btnLuuChiTiet";
            this.btnLuuChiTiet.Size = new System.Drawing.Size(102, 34);
            this.btnLuuChiTiet.TabIndex = 109;
            this.btnLuuChiTiet.Text = "Thêm";
            this.btnLuuChiTiet.UseVisualStyleBackColor = true;
            this.btnLuuChiTiet.Click += new System.EventHandler(this.btnLuuChiTiet_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(31, 18);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(365, 16);
            this.lblWarning.TabIndex = 82;
            this.lblWarning.Text = "Lưu ý: Không thể cập nhật chi tiết đối với thực đơn đã áp dụng";
            this.lblWarning.Visible = false;
            // 
            // btnReloadMonAn
            // 
            this.btnReloadMonAn.BackColor = System.Drawing.Color.Lavender;
            this.btnReloadMonAn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReloadMonAn.Location = new System.Drawing.Point(424, 375);
            this.btnReloadMonAn.Name = "btnReloadMonAn";
            this.btnReloadMonAn.Size = new System.Drawing.Size(32, 28);
            this.btnReloadMonAn.TabIndex = 80;
            this.btnReloadMonAn.UseVisualStyleBackColor = false;
            // 
            // txtMaThucDon2
            // 
            this.txtMaThucDon2.Enabled = false;
            this.txtMaThucDon2.Location = new System.Drawing.Point(246, 348);
            this.txtMaThucDon2.Name = "txtMaThucDon2";
            this.txtMaThucDon2.Size = new System.Drawing.Size(209, 22);
            this.txtMaThucDon2.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(250, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(130, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Mã thực đơn: ";
            // 
            // dgvChiTietThucDon
            // 
            this.dgvChiTietThucDon.AllowUserToAddRows = false;
            this.dgvChiTietThucDon.AllowUserToDeleteRows = false;
            this.dgvChiTietThucDon.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietThucDon.Location = new System.Drawing.Point(6, 50);
            this.dgvChiTietThucDon.Name = "dgvChiTietThucDon";
            this.dgvChiTietThucDon.ReadOnly = true;
            this.dgvChiTietThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietThucDon.Size = new System.Drawing.Size(532, 265);
            this.dgvChiTietThucDon.TabIndex = 44;
            this.dgvChiTietThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietThucDon_CellClick);
            // 
            // cboMonAn
            // 
            this.cboMonAn.BackColor = System.Drawing.SystemColors.Window;
            this.cboMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonAn.FormattingEnabled = true;
            this.cboMonAn.Location = new System.Drawing.Point(246, 375);
            this.cboMonAn.Name = "cboMonAn";
            this.cboMonAn.Size = new System.Drawing.Size(171, 24);
            this.cboMonAn.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(131, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tên món ăn: ";
            // 
            // frmDinhDuong_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDinhDuong_ThucDon";
            this.Text = "frmDinhDuong_ThucDon";
            this.Load += new System.EventHandler(this.frmDinhDuong_ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtMaThucDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnReloadMonAn;
        private System.Windows.Forms.TextBox txtMaThucDon2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvChiTietThucDon;
        private System.Windows.Forms.ComboBox cboMonAn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Button btnLuuChiTiet;
    }
}