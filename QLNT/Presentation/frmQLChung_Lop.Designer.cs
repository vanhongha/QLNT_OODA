namespace QLNT.Presentation
{
    partial class frmQLChung_Lop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoQuyDinh = new System.Windows.Forms.RadioButton();
            this.rdoQLNienKhoa = new System.Windows.Forms.RadioButton();
            this.rdoQLLoaiLop = new System.Windows.Forms.RadioButton();
            this.rdoQLLop = new System.Windows.Forms.RadioButton();
            this.grpQLLop = new System.Windows.Forms.GroupBox();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.cboBaoMau2 = new System.Windows.Forms.ComboBox();
            this.cboBaoMau1 = new System.Windows.Forms.ComboBox();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpQLLoaiLop = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiLop = new System.Windows.Forms.TextBox();
            this.txtMaLoaiLop = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grpQLNienKhoa = new System.Windows.Forms.GroupBox();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtTenNienKhoa = new System.Windows.Forms.TextBox();
            this.txtMaNienKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSiSoToiDa = new System.Windows.Forms.TextBox();
            this.grpQLQuyDinh = new System.Windows.Forms.GroupBox();
            this.btnFresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpQLLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grpQLLoaiLop.SuspendLayout();
            this.grpQLNienKhoa.SuspendLayout();
            this.grpQLQuyDinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý chung lớp - Loại lớp - Niên khóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoQuyDinh);
            this.groupBox1.Controls.Add(this.rdoQLNienKhoa);
            this.groupBox1.Controls.Add(this.rdoQLLoaiLop);
            this.groupBox1.Controls.Add(this.rdoQLLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(172, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // rdoQuyDinh
            // 
            this.rdoQuyDinh.AutoSize = true;
            this.rdoQuyDinh.Location = new System.Drawing.Point(489, 14);
            this.rdoQuyDinh.Name = "rdoQuyDinh";
            this.rdoQuyDinh.Size = new System.Drawing.Size(143, 24);
            this.rdoQuyDinh.TabIndex = 0;
            this.rdoQuyDinh.TabStop = true;
            this.rdoQuyDinh.Text = "Quản lý quy định";
            this.rdoQuyDinh.UseVisualStyleBackColor = true;
            this.rdoQuyDinh.CheckedChanged += new System.EventHandler(this.rdoQuyDinh_CheckedChanged);
            // 
            // rdoQLNienKhoa
            // 
            this.rdoQLNienKhoa.AutoSize = true;
            this.rdoQLNienKhoa.Location = new System.Drawing.Point(330, 14);
            this.rdoQLNienKhoa.Name = "rdoQLNienKhoa";
            this.rdoQLNienKhoa.Size = new System.Drawing.Size(153, 24);
            this.rdoQLNienKhoa.TabIndex = 0;
            this.rdoQLNienKhoa.TabStop = true;
            this.rdoQLNienKhoa.Text = "Quản lý niên khóa";
            this.rdoQLNienKhoa.UseVisualStyleBackColor = true;
            this.rdoQLNienKhoa.CheckedChanged += new System.EventHandler(this.rdoQLNienKhoa_CheckedChanged);
            // 
            // rdoQLLoaiLop
            // 
            this.rdoQLLoaiLop.AutoSize = true;
            this.rdoQLLoaiLop.Location = new System.Drawing.Point(191, 14);
            this.rdoQLLoaiLop.Name = "rdoQLLoaiLop";
            this.rdoQLLoaiLop.Size = new System.Drawing.Size(133, 24);
            this.rdoQLLoaiLop.TabIndex = 0;
            this.rdoQLLoaiLop.TabStop = true;
            this.rdoQLLoaiLop.Text = "Quản lý loại lớp";
            this.rdoQLLoaiLop.UseVisualStyleBackColor = true;
            this.rdoQLLoaiLop.CheckedChanged += new System.EventHandler(this.rdoQLLoaiLop_CheckedChanged);
            // 
            // rdoQLLop
            // 
            this.rdoQLLop.AutoSize = true;
            this.rdoQLLop.Location = new System.Drawing.Point(80, 14);
            this.rdoQLLop.Name = "rdoQLLop";
            this.rdoQLLop.Size = new System.Drawing.Size(105, 24);
            this.rdoQLLop.TabIndex = 0;
            this.rdoQLLop.TabStop = true;
            this.rdoQLLop.Text = "Quản lý lớp";
            this.rdoQLLop.UseVisualStyleBackColor = true;
            this.rdoQLLop.CheckedChanged += new System.EventHandler(this.rdoQLLop_CheckedChanged);
            // 
            // grpQLLop
            // 
            this.grpQLLop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpQLLop.Controls.Add(this.cboLoaiLop);
            this.grpQLLop.Controls.Add(this.cboBaoMau2);
            this.grpQLLop.Controls.Add(this.cboBaoMau1);
            this.grpQLLop.Controls.Add(this.cboGiangVien);
            this.grpQLLop.Controls.Add(this.cboNienKhoa);
            this.grpQLLop.Controls.Add(this.txtSiSo);
            this.grpQLLop.Controls.Add(this.txtTenLop);
            this.grpQLLop.Controls.Add(this.txtMaLop);
            this.grpQLLop.Controls.Add(this.label9);
            this.grpQLLop.Controls.Add(this.label8);
            this.grpQLLop.Controls.Add(this.label7);
            this.grpQLLop.Controls.Add(this.label6);
            this.grpQLLop.Controls.Add(this.label5);
            this.grpQLLop.Controls.Add(this.label4);
            this.grpQLLop.Controls.Add(this.label3);
            this.grpQLLop.Controls.Add(this.label2);
            this.grpQLLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQLLop.Location = new System.Drawing.Point(12, 364);
            this.grpQLLop.Name = "grpQLLop";
            this.grpQLLop.Size = new System.Drawing.Size(1005, 103);
            this.grpQLLop.TabIndex = 2;
            this.grpQLLop.TabStop = false;
            this.grpQLLop.Text = "Quản lý lớp";
            // 
            // cboLoaiLop
            // 
            this.cboLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiLop.FormattingEnabled = true;
            this.cboLoaiLop.Location = new System.Drawing.Point(608, 60);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(137, 28);
            this.cboLoaiLop.TabIndex = 2;
            // 
            // cboBaoMau2
            // 
            this.cboBaoMau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaoMau2.FormattingEnabled = true;
            this.cboBaoMau2.Location = new System.Drawing.Point(847, 60);
            this.cboBaoMau2.Name = "cboBaoMau2";
            this.cboBaoMau2.Size = new System.Drawing.Size(137, 28);
            this.cboBaoMau2.TabIndex = 2;
            // 
            // cboBaoMau1
            // 
            this.cboBaoMau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaoMau1.FormattingEnabled = true;
            this.cboBaoMau1.Location = new System.Drawing.Point(847, 27);
            this.cboBaoMau1.Name = "cboBaoMau1";
            this.cboBaoMau1.Size = new System.Drawing.Size(137, 28);
            this.cboBaoMau1.TabIndex = 2;
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGiangVien.FormattingEnabled = true;
            this.cboGiangVien.Location = new System.Drawing.Point(608, 27);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(137, 28);
            this.cboGiangVien.TabIndex = 2;
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Location = new System.Drawing.Point(369, 27);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(137, 28);
            this.cboNienKhoa.TabIndex = 2;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo.Location = new System.Drawing.Point(369, 62);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(137, 26);
            this.txtSiSo.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(72, 62);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(201, 26);
            this.txtTenLop.TabIndex = 1;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(72, 29);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(201, 26);
            this.txtMaLop.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(751, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bảo mẫu 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(751, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bảo mẫu 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Niên khóa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giáo viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sĩ số:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.GridColor = System.Drawing.Color.White;
            this.dgvDanhSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 104);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(1005, 254);
            this.dgvDanhSach.TabIndex = 3;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(396, 473);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 43);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(508, 473);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(106, 43);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(620, 473);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(106, 43);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpQLLoaiLop
            // 
            this.grpQLLoaiLop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpQLLoaiLop.Controls.Add(this.txtTenLoaiLop);
            this.grpQLLoaiLop.Controls.Add(this.txtMaLoaiLop);
            this.grpQLLoaiLop.Controls.Add(this.label16);
            this.grpQLLoaiLop.Controls.Add(this.label17);
            this.grpQLLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQLLoaiLop.Location = new System.Drawing.Point(12, 364);
            this.grpQLLoaiLop.Name = "grpQLLoaiLop";
            this.grpQLLoaiLop.Size = new System.Drawing.Size(1005, 103);
            this.grpQLLoaiLop.TabIndex = 9;
            this.grpQLLoaiLop.TabStop = false;
            this.grpQLLoaiLop.Text = "Quản lý loại lớp";
            // 
            // txtTenLoaiLop
            // 
            this.txtTenLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiLop.Location = new System.Drawing.Point(80, 62);
            this.txtTenLoaiLop.Name = "txtTenLoaiLop";
            this.txtTenLoaiLop.Size = new System.Drawing.Size(919, 26);
            this.txtTenLoaiLop.TabIndex = 1;
            // 
            // txtMaLoaiLop
            // 
            this.txtMaLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiLop.Location = new System.Drawing.Point(80, 29);
            this.txtMaLoaiLop.Name = "txtMaLoaiLop";
            this.txtMaLoaiLop.ReadOnly = true;
            this.txtMaLoaiLop.Size = new System.Drawing.Size(919, 26);
            this.txtMaLoaiLop.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tên loại:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mã loại:";
            // 
            // grpQLNienKhoa
            // 
            this.grpQLNienKhoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpQLNienKhoa.Controls.Add(this.dtNgayKetThuc);
            this.grpQLNienKhoa.Controls.Add(this.dtNgayBatDau);
            this.grpQLNienKhoa.Controls.Add(this.txtTenNienKhoa);
            this.grpQLNienKhoa.Controls.Add(this.txtMaNienKhoa);
            this.grpQLNienKhoa.Controls.Add(this.label10);
            this.grpQLNienKhoa.Controls.Add(this.label11);
            this.grpQLNienKhoa.Controls.Add(this.label12);
            this.grpQLNienKhoa.Controls.Add(this.label13);
            this.grpQLNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQLNienKhoa.Location = new System.Drawing.Point(12, 364);
            this.grpQLNienKhoa.Name = "grpQLNienKhoa";
            this.grpQLNienKhoa.Size = new System.Drawing.Size(1005, 103);
            this.grpQLNienKhoa.TabIndex = 9;
            this.grpQLNienKhoa.TabStop = false;
            this.grpQLNienKhoa.Text = "Quản lý niên khóa";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(712, 63);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(286, 26);
            this.dtNgayKetThuc.TabIndex = 2;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(712, 30);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(286, 26);
            this.dtNgayBatDau.TabIndex = 2;
            // 
            // txtTenNienKhoa
            // 
            this.txtTenNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNienKhoa.Location = new System.Drawing.Point(125, 62);
            this.txtTenNienKhoa.Name = "txtTenNienKhoa";
            this.txtTenNienKhoa.Size = new System.Drawing.Size(468, 26);
            this.txtTenNienKhoa.TabIndex = 1;
            // 
            // txtMaNienKhoa
            // 
            this.txtMaNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNienKhoa.Location = new System.Drawing.Point(125, 29);
            this.txtMaNienKhoa.Name = "txtMaNienKhoa";
            this.txtMaNienKhoa.ReadOnly = true;
            this.txtMaNienKhoa.Size = new System.Drawing.Size(468, 26);
            this.txtMaNienKhoa.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên niên khóa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(599, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày kết thúc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(602, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày bắt đầu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã niên khóa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Sĩ số tối đa:";
            // 
            // txtSiSoToiDa
            // 
            this.txtSiSoToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSoToiDa.Location = new System.Drawing.Point(121, 48);
            this.txtSiSoToiDa.Name = "txtSiSoToiDa";
            this.txtSiSoToiDa.Size = new System.Drawing.Size(52, 26);
            this.txtSiSoToiDa.TabIndex = 11;
            // 
            // grpQLQuyDinh
            // 
            this.grpQLQuyDinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpQLQuyDinh.Controls.Add(this.txtSiSoToiDa);
            this.grpQLQuyDinh.Controls.Add(this.label14);
            this.grpQLQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQLQuyDinh.Location = new System.Drawing.Point(405, 139);
            this.grpQLQuyDinh.Name = "grpQLQuyDinh";
            this.grpQLQuyDinh.Size = new System.Drawing.Size(200, 100);
            this.grpQLQuyDinh.TabIndex = 12;
            this.grpQLQuyDinh.TabStop = false;
            this.grpQLQuyDinh.Text = "Quản lý quy định";
            // 
            // btnFresh
            // 
            this.btnFresh.Image = global::QLNT.Properties.Resources.icons8_available_updates_48;
            this.btnFresh.Location = new System.Drawing.Point(960, 54);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(57, 44);
            this.btnFresh.TabIndex = 13;
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // frmQLChung_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 519);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.grpQLQuyDinh);
            this.Controls.Add(this.grpQLNienKhoa);
            this.Controls.Add(this.grpQLLoaiLop);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.grpQLLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLChung_Lop";
            this.Text = "frmQLChung_Lop";
            this.Load += new System.EventHandler(this.frmQLChung_Lop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpQLLop.ResumeLayout(false);
            this.grpQLLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpQLLoaiLop.ResumeLayout(false);
            this.grpQLLoaiLop.PerformLayout();
            this.grpQLNienKhoa.ResumeLayout(false);
            this.grpQLNienKhoa.PerformLayout();
            this.grpQLQuyDinh.ResumeLayout(false);
            this.grpQLQuyDinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoQLNienKhoa;
        private System.Windows.Forms.RadioButton rdoQLLoaiLop;
        private System.Windows.Forms.RadioButton rdoQLLop;
        private System.Windows.Forms.GroupBox grpQLLop;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.ComboBox cboLoaiLop;
        private System.Windows.Forms.ComboBox cboGiangVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboBaoMau1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboBaoMau2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpQLLoaiLop;
        private System.Windows.Forms.TextBox txtTenLoaiLop;
        private System.Windows.Forms.TextBox txtMaLoaiLop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpQLNienKhoa;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.TextBox txtTenNienKhoa;
        private System.Windows.Forms.TextBox txtMaNienKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoQuyDinh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSiSoToiDa;
        private System.Windows.Forms.GroupBox grpQLQuyDinh;
        private System.Windows.Forms.Button btnFresh;
    }
}