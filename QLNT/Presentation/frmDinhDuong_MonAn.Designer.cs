﻿namespace QLNT.Presentation
{
    partial class frmDinhDuong_MonAn
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
            this.lblWarning = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaTrangNL = new System.Windows.Forms.Button();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.btnLuuChiTiet = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.cboChonNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKhoiLuong = new System.Windows.Forms.TextBox();
            this.txtNangLuongChiTiet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvChiTietMonAn = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.txtNangLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMonAn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(183, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(371, 16);
            this.lblWarning.TabIndex = 84;
            this.lblWarning.Text = "Không thể cập nhật chi tiết món ăn đã được thêm vào thực đơn";
            this.lblWarning.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaTrangNL);
            this.groupBox1.Controls.Add(this.btnXoaChiTiet);
            this.groupBox1.Controls.Add(this.btnLuuChiTiet);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.cboChonNguyenLieu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKhoiLuong);
            this.groupBox1.Controls.Add(this.txtNangLuongChiTiet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.dgvChiTietMonAn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(581, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 463);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NGUYÊN LIỆU TỪNG MÓN";
            // 
            // btnXoaTrangNL
            // 
            this.btnXoaTrangNL.Location = new System.Drawing.Point(106, 417);
            this.btnXoaTrangNL.Name = "btnXoaTrangNL";
            this.btnXoaTrangNL.Size = new System.Drawing.Size(102, 34);
            this.btnXoaTrangNL.TabIndex = 111;
            this.btnXoaTrangNL.Text = "Xóa Trắng";
            this.btnXoaTrangNL.UseVisualStyleBackColor = true;
            this.btnXoaTrangNL.Click += new System.EventHandler(this.btnXoaTrangNL_Click);
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Location = new System.Drawing.Point(322, 417);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(102, 34);
            this.btnXoaChiTiet.TabIndex = 110;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnLuuChiTiet
            // 
            this.btnLuuChiTiet.Location = new System.Drawing.Point(214, 417);
            this.btnLuuChiTiet.Name = "btnLuuChiTiet";
            this.btnLuuChiTiet.Size = new System.Drawing.Size(102, 34);
            this.btnLuuChiTiet.TabIndex = 109;
            this.btnLuuChiTiet.Text = "Lưu";
            this.btnLuuChiTiet.UseVisualStyleBackColor = true;
            this.btnLuuChiTiet.Click += new System.EventHandler(this.btnLuuChiTiet_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Lavender;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReload.Location = new System.Drawing.Point(392, 319);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 27);
            this.btnReload.TabIndex = 107;
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // cboChonNguyenLieu
            // 
            this.cboChonNguyenLieu.FormattingEnabled = true;
            this.cboChonNguyenLieu.Location = new System.Drawing.Point(200, 321);
            this.cboChonNguyenLieu.Name = "cboChonNguyenLieu";
            this.cboChonNguyenLieu.Size = new System.Drawing.Size(186, 24);
            this.cboChonNguyenLieu.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(102, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 105;
            this.label5.Text = "Nguyên liệu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(222, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 103;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.Location = new System.Drawing.Point(200, 351);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Size = new System.Drawing.Size(223, 22);
            this.txtKhoiLuong.TabIndex = 101;
            this.txtKhoiLuong.Text = "0";
            // 
            // txtNangLuongChiTiet
            // 
            this.txtNangLuongChiTiet.Enabled = false;
            this.txtNangLuongChiTiet.Location = new System.Drawing.Point(200, 380);
            this.txtNangLuongChiTiet.Name = "txtNangLuongChiTiet";
            this.txtNangLuongChiTiet.Size = new System.Drawing.Size(225, 22);
            this.txtNangLuongChiTiet.TabIndex = 100;
            this.txtNangLuongChiTiet.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(102, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "Khối lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(102, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 98;
            this.label6.Text = "Năng lượng";
            // 
            // dgvChiTietMonAn
            // 
            this.dgvChiTietMonAn.AllowUserToAddRows = false;
            this.dgvChiTietMonAn.AllowUserToDeleteRows = false;
            this.dgvChiTietMonAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietMonAn.Location = new System.Drawing.Point(28, 32);
            this.dgvChiTietMonAn.Name = "dgvChiTietMonAn";
            this.dgvChiTietMonAn.ReadOnly = true;
            this.dgvChiTietMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietMonAn.Size = new System.Drawing.Size(531, 258);
            this.dgvChiTietMonAn.TabIndex = 44;
            this.dgvChiTietMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietMonAn_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNangLuong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoaTrang);
            this.groupBox2.Controls.Add(this.txtTenMonAn);
            this.groupBox2.Controls.Add(this.txtMaMonAn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvMonAn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 463);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MÓN ĂN";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(278, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 34);
            this.btnXoa.TabIndex = 104;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(168, 417);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 34);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(58, 417);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(102, 34);
            this.btnXoaTrang.TabIndex = 102;
            this.btnXoaTrang.Text = "Xóa Trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(142, 352);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(238, 22);
            this.txtTenMonAn.TabIndex = 101;
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Enabled = false;
            this.txtMaMonAn.Location = new System.Drawing.Point(142, 324);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(238, 22);
            this.txtMaMonAn.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(57, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mã món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(54, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "Tên món ăn:";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(21, 32);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(518, 258);
            this.dgvMonAn.TabIndex = 45;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // txtNangLuong
            // 
            this.txtNangLuong.Enabled = false;
            this.txtNangLuong.Location = new System.Drawing.Point(142, 379);
            this.txtNangLuong.Name = "txtNangLuong";
            this.txtNangLuong.Size = new System.Drawing.Size(238, 22);
            this.txtNangLuong.TabIndex = 106;
            this.txtNangLuong.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(55, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Năng lượng";
            // 
            // frmDinhDuong_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDinhDuong_MonAn";
            this.Text = "frmDinhDuong_MonAn";
            this.Load += new System.EventHandler(this.frmDinhDuong_MonAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMonAn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietMonAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Button btnLuuChiTiet;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cboChonNguyenLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKhoiLuong;
        private System.Windows.Forms.TextBox txtNangLuongChiTiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaTrangNL;
        private System.Windows.Forms.TextBox txtNangLuong;
        private System.Windows.Forms.Label label1;
    }
}