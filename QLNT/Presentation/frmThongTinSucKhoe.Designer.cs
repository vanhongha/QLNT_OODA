﻿namespace QLNT.Presentation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenTre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSucKhoe = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiLop
            // 
            this.cboLoaiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiLop.FormattingEnabled = true;
            this.cboLoaiLop.Location = new System.Drawing.Point(127, 56);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(160, 28);
            this.cboLoaiLop.TabIndex = 1;
            this.cboLoaiLop.SelectedIndexChanged += new System.EventHandler(this.cboLoaiLop_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboLoaiLop);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSiSo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboThang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboLop);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboNamHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 146);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm học";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo.Location = new System.Drawing.Point(466, 58);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(60, 26);
            this.txtSiSo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại lớp";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(466, 14);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(60, 28);
            this.cboThang.TabIndex = 1;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp học";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(127, 98);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(160, 28);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sỉ số lớp";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(127, 14);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(160, 28);
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(654, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 490);
            this.panel3.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(423, 422);
            this.panel6.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenTre);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.txtBMI);
            this.groupBox1.Controls.Add(this.txtChieuCao);
            this.groupBox1.Controls.Add(this.txtCanNang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 422);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sức khỏe";
            // 
            // txtTenTre
            // 
            this.txtTenTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTre.Location = new System.Drawing.Point(146, 36);
            this.txtTenTre.Name = "txtTenTre";
            this.txtTenTre.ReadOnly = true;
            this.txtTenTre.Size = new System.Drawing.Size(244, 30);
            this.txtTenTre.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Location = new System.Drawing.Point(20, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên trẻ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(146, 299);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(244, 93);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.Text = "";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(146, 242);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(244, 30);
            this.txtTinhTrang.TabIndex = 6;
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(146, 192);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(244, 30);
            this.txtBMI.TabIndex = 6;
            this.txtBMI.TextChanged += new System.EventHandler(this.txtBMI_TextChanged);
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChieuCao.Location = new System.Drawing.Point(146, 141);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(244, 30);
            this.txtChieuCao.TabIndex = 6;
            this.txtChieuCao.TextChanged += new System.EventHandler(this.txtChieuCao_TextChanged);
            // 
            // txtCanNang
            // 
            this.txtCanNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanNang.Location = new System.Drawing.Point(146, 88);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(244, 30);
            this.txtCanNang.TabIndex = 6;
            this.txtCanNang.TextChanged += new System.EventHandler(this.txtCanNang_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chiều Cao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cân Nặng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.Location = new System.Drawing.Point(20, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tình trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "BMI";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDong);
            this.panel5.Controls.Add(this.btnCapNhat);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 422);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 68);
            this.panel5.TabIndex = 30;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(230, 14);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(142, 42);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(29, 14);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(142, 42);
            this.btnCapNhat.TabIndex = 33;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 636);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSucKhoe);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(654, 490);
            this.panel4.TabIndex = 16;
            // 
            // dgvSucKhoe
            // 
            this.dgvSucKhoe.AllowUserToAddRows = false;
            this.dgvSucKhoe.AllowUserToDeleteRows = false;
            this.dgvSucKhoe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSucKhoe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucKhoe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucKhoe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSucKhoe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSucKhoe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSucKhoe.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSucKhoe.Location = new System.Drawing.Point(0, 0);
            this.dgvSucKhoe.MultiSelect = false;
            this.dgvSucKhoe.Name = "dgvSucKhoe";
            this.dgvSucKhoe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSucKhoe.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSucKhoe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucKhoe.ShowCellErrors = false;
            this.dgvSucKhoe.ShowCellToolTips = false;
            this.dgvSucKhoe.ShowEditingIcon = false;
            this.dgvSucKhoe.ShowRowErrors = false;
            this.dgvSucKhoe.Size = new System.Drawing.Size(654, 490);
            this.dgvSucKhoe.TabIndex = 26;
            this.dgvSucKhoe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucKhoe_CellClick);
            // 
            // frmThongTinSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 636);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinSucKhoe";
            this.Text = "frmThongTinSucKhoe";
            this.Load += new System.EventHandler(this.frmThongTinSucKhoe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucKhoe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboLoaiLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSucKhoe;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenTre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}