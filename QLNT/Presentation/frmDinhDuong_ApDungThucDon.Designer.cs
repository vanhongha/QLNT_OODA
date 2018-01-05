namespace QLNT.Presentation
{
    partial class frmDinhDuong_ApDungThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDinhDuong_ApDungThucDon));
            this.cboBuoiAD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgay_Loc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dgvTreChuaXetThucDon = new System.Windows.Forms.DataGridView();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.ckbAll_TreDaXetTD = new System.Windows.Forms.CheckBox();
            this.dgvTreDaXetThucDon = new System.Windows.Forms.DataGridView();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.cboTenMonAn = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTongNangLuong = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatDanhSachTheoLop = new System.Windows.Forms.Button();
            this.btnBaoCaoNhaBep = new System.Windows.Forms.Button();
            this.dgvThongTinThucDon_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.dgvThongTinThucDon_MonAn = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreChuaXetThucDon)).BeginInit();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreDaXetThucDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinThucDon_NguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinThucDon_MonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBuoiAD
            // 
            this.cboBuoiAD.AccessibleDescription = "";
            this.cboBuoiAD.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboBuoiAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuoiAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuoiAD.FormattingEnabled = true;
            this.cboBuoiAD.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboBuoiAD.Location = new System.Drawing.Point(101, 60);
            this.cboBuoiAD.Name = "cboBuoiAD";
            this.cboBuoiAD.Size = new System.Drawing.Size(140, 24);
            this.cboBuoiAD.TabIndex = 101;
            this.cboBuoiAD.SelectedIndexChanged += new System.EventHandler(this.cboBuoiAD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Chọn Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(27, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Chọn Buổi:";
            // 
            // dtpNgay_Loc
            // 
            this.dtpNgay_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay_Loc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_Loc.Location = new System.Drawing.Point(101, 32);
            this.dtpNgay_Loc.Name = "dtpNgay_Loc";
            this.dtpNgay_Loc.Size = new System.Drawing.Size(140, 22);
            this.dtpNgay_Loc.TabIndex = 100;
            this.dtpNgay_Loc.Value = new System.DateTime(2017, 5, 31, 20, 12, 25, 0);
            this.dtpNgay_Loc.ValueChanged += new System.EventHandler(this.dtpNgay_Loc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(64, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 112;
            this.label2.Text = "Lớp:";
            // 
            // cboLoaiLop
            // 
            this.cboLoaiLop.AccessibleDescription = "";
            this.cboLoaiLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboLoaiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiLop.FormattingEnabled = true;
            this.cboLoaiLop.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboLoaiLop.Location = new System.Drawing.Point(101, 90);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(140, 24);
            this.cboLoaiLop.TabIndex = 109;
            this.cboLoaiLop.SelectedIndexChanged += new System.EventHandler(this.cboLoaiLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Loại Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.AccessibleDescription = "";
            this.cboLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboLop.Location = new System.Drawing.Point(101, 120);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(140, 24);
            this.cboLop.TabIndex = 114;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // dgvTreChuaXetThucDon
            // 
            this.dgvTreChuaXetThucDon.AllowUserToAddRows = false;
            this.dgvTreChuaXetThucDon.AllowUserToDeleteRows = false;
            this.dgvTreChuaXetThucDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTreChuaXetThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreChuaXetThucDon.Location = new System.Drawing.Point(6, 19);
            this.dgvTreChuaXetThucDon.Name = "dgvTreChuaXetThucDon";
            this.dgvTreChuaXetThucDon.ReadOnly = true;
            this.dgvTreChuaXetThucDon.RowHeadersVisible = false;
            this.dgvTreChuaXetThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreChuaXetThucDon.Size = new System.Drawing.Size(546, 236);
            this.dgvTreChuaXetThucDon.TabIndex = 98;
            this.dgvTreChuaXetThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreChuaXetThucDon_CellClick);
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(27, 26);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(15, 14);
            this.ckbAll.TabIndex = 129;
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.Click += new System.EventHandler(this.ckbAll_Click);
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.ckbAll);
            this.gbx.Controls.Add(this.dgvTreChuaXetThucDon);
            this.gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbx.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbx.Location = new System.Drawing.Point(9, 274);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(559, 261);
            this.gbx.TabIndex = 105;
            this.gbx.TabStop = false;
            this.gbx.Text = "DANH SÁCH TRẺ CHƯA XÉT THỰC ĐƠN";
            // 
            // ckbAll_TreDaXetTD
            // 
            this.ckbAll_TreDaXetTD.AutoSize = true;
            this.ckbAll_TreDaXetTD.Location = new System.Drawing.Point(26, 26);
            this.ckbAll_TreDaXetTD.Name = "ckbAll_TreDaXetTD";
            this.ckbAll_TreDaXetTD.Size = new System.Drawing.Size(15, 14);
            this.ckbAll_TreDaXetTD.TabIndex = 135;
            this.ckbAll_TreDaXetTD.UseVisualStyleBackColor = true;
            this.ckbAll_TreDaXetTD.Click += new System.EventHandler(this.ckbAll_TreDaXetTD_Click);
            // 
            // dgvTreDaXetThucDon
            // 
            this.dgvTreDaXetThucDon.AllowUserToAddRows = false;
            this.dgvTreDaXetThucDon.AllowUserToDeleteRows = false;
            this.dgvTreDaXetThucDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTreDaXetThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreDaXetThucDon.Location = new System.Drawing.Point(6, 20);
            this.dgvTreDaXetThucDon.Name = "dgvTreDaXetThucDon";
            this.dgvTreDaXetThucDon.ReadOnly = true;
            this.dgvTreDaXetThucDon.RowHeadersVisible = false;
            this.dgvTreDaXetThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreDaXetThucDon.Size = new System.Drawing.Size(542, 235);
            this.dgvTreDaXetThucDon.TabIndex = 134;
            this.dgvTreDaXetThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreDaXetThucDon_CellClick);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.Image")));
            this.btnRemoveAll.Location = new System.Drawing.Point(567, 456);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(48, 34);
            this.btnRemoveAll.TabIndex = 133;
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(567, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 34);
            this.btnAdd.TabIndex = 130;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.Image")));
            this.btnAddAll.Location = new System.Drawing.Point(567, 376);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(48, 34);
            this.btnAddAll.TabIndex = 131;
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(567, 420);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(48, 34);
            this.btnRemove.TabIndex = 132;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReload);
            this.groupBox3.Controls.Add(this.cboTenMonAn);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.dgvMonAn);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.lblTongNangLuong);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(252, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 243);
            this.groupBox3.TabIndex = 130;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỌN MÓN ĂN";
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(230, 173);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(26, 26);
            this.btnReload.TabIndex = 145;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cboTenMonAn
            // 
            this.cboTenMonAn.AccessibleDescription = "";
            this.cboTenMonAn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTenMonAn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTenMonAn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenMonAn.FormattingEnabled = true;
            this.cboTenMonAn.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboTenMonAn.Location = new System.Drawing.Point(113, 174);
            this.cboTenMonAn.Name = "cboTenMonAn";
            this.cboTenMonAn.Size = new System.Drawing.Size(117, 24);
            this.cboTenMonAn.TabIndex = 144;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Location = new System.Drawing.Point(163, 202);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 34);
            this.btnXoa.TabIndex = 132;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMonAn.CausesValidation = false;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(6, 20);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(303, 147);
            this.dgvMonAn.TabIndex = 143;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Location = new System.Drawing.Point(78, 202);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 34);
            this.btnThem.TabIndex = 131;
            this.btnThem.Text = "Chọn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTongNangLuong
            // 
            this.lblTongNangLuong.AutoSize = true;
            this.lblTongNangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNangLuong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTongNangLuong.Location = new System.Drawing.Point(139, 0);
            this.lblTongNangLuong.Name = "lblTongNangLuong";
            this.lblTongNangLuong.Size = new System.Drawing.Size(144, 16);
            this.lblTongNangLuong.TabIndex = 142;
            this.lblTongNangLuong.Text = "Tổng năng lượng:  0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label29.Location = new System.Drawing.Point(51, 178);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 16);
            this.label29.TabIndex = 129;
            this.label29.Text = "Tên món: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnXuatDanhSachTheoLop);
            this.groupBox1.Controls.Add(this.btnBaoCaoNhaBep);
            this.groupBox1.Controls.Add(this.dgvThongTinThucDon_NguyenLieu);
            this.groupBox1.Controls.Add(this.dgvThongTinThucDon_MonAn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(614, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 243);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN THỰC ĐƠN  ĐÃ XÉT";
            // 
            // btnXuatDanhSachTheoLop
            // 
            this.btnXuatDanhSachTheoLop.Location = new System.Drawing.Point(439, 170);
            this.btnXuatDanhSachTheoLop.Name = "btnXuatDanhSachTheoLop";
            this.btnXuatDanhSachTheoLop.Size = new System.Drawing.Size(110, 66);
            this.btnXuatDanhSachTheoLop.TabIndex = 138;
            this.btnXuatDanhSachTheoLop.Text = "Xuất danh sách thực đơn theo lớp";
            this.btnXuatDanhSachTheoLop.UseVisualStyleBackColor = true;
            this.btnXuatDanhSachTheoLop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBaoCaoNhaBep
            // 
            this.btnBaoCaoNhaBep.Location = new System.Drawing.Point(439, 130);
            this.btnBaoCaoNhaBep.Name = "btnBaoCaoNhaBep";
            this.btnBaoCaoNhaBep.Size = new System.Drawing.Size(110, 34);
            this.btnBaoCaoNhaBep.TabIndex = 137;
            this.btnBaoCaoNhaBep.Text = "Báo cáo nhà bếp";
            this.btnBaoCaoNhaBep.UseVisualStyleBackColor = true;
            this.btnBaoCaoNhaBep.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvThongTinThucDon_NguyenLieu
            // 
            this.dgvThongTinThucDon_NguyenLieu.AllowUserToAddRows = false;
            this.dgvThongTinThucDon_NguyenLieu.AllowUserToDeleteRows = false;
            this.dgvThongTinThucDon_NguyenLieu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinThucDon_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinThucDon_NguyenLieu.Location = new System.Drawing.Point(7, 128);
            this.dgvThongTinThucDon_NguyenLieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTinThucDon_NguyenLieu.Name = "dgvThongTinThucDon_NguyenLieu";
            this.dgvThongTinThucDon_NguyenLieu.ReadOnly = true;
            this.dgvThongTinThucDon_NguyenLieu.RowHeadersVisible = false;
            this.dgvThongTinThucDon_NguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinThucDon_NguyenLieu.Size = new System.Drawing.Size(427, 108);
            this.dgvThongTinThucDon_NguyenLieu.TabIndex = 136;
            // 
            // dgvThongTinThucDon_MonAn
            // 
            this.dgvThongTinThucDon_MonAn.AllowUserToAddRows = false;
            this.dgvThongTinThucDon_MonAn.AllowUserToDeleteRows = false;
            this.dgvThongTinThucDon_MonAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinThucDon_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinThucDon_MonAn.Location = new System.Drawing.Point(7, 20);
            this.dgvThongTinThucDon_MonAn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTinThucDon_MonAn.Name = "dgvThongTinThucDon_MonAn";
            this.dgvThongTinThucDon_MonAn.ReadOnly = true;
            this.dgvThongTinThucDon_MonAn.RowHeadersVisible = false;
            this.dgvThongTinThucDon_MonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinThucDon_MonAn.Size = new System.Drawing.Size(541, 103);
            this.dgvThongTinThucDon_MonAn.TabIndex = 135;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1177, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 137;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckbAll_TreDaXetTD);
            this.groupBox2.Controls.Add(this.dgvTreDaXetThucDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(614, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 261);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH TRẺ ĐÃ XÉT THỰC ĐƠN";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Crimson;
            this.lblNote.Location = new System.Drawing.Point(22, 14);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(223, 14);
            this.lblNote.TabIndex = 139;
            this.lblNote.Text = "Không thể cập nhật thực đơn cho ngày đã qua";
            this.lblNote.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 98);
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox4.Controls.Add(this.gbx);
            this.groupBox4.Controls.Add(this.lblNote);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnRemoveAll);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.btnAddAll);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Controls.Add(this.cboLop);
            this.groupBox4.Controls.Add(this.dtpNgay_Loc);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboLoaiLop);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cboBuoiAD);
            this.groupBox4.Location = new System.Drawing.Point(14, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1176, 550);
            this.groupBox4.TabIndex = 141;
            this.groupBox4.TabStop = false;
            // 
            // frmDinhDuong_ApDungThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 581);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.closeBtn);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 557);
            this.Name = "frmDinhDuong_ApDungThucDon";
            this.Text = "Sáng";
            this.Load += new System.EventHandler(this.frmDinhDuong_ApDungThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreChuaXetThucDon)).EndInit();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreDaXetThucDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinThucDon_NguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinThucDon_MonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBuoiAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay_Loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.DataGridView dgvTreChuaXetThucDon;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.Label lblTongNangLuong;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTenMonAn;
        private System.Windows.Forms.CheckBox ckbAll_TreDaXetTD;
        private System.Windows.Forms.DataGridView dgvTreDaXetThucDon;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongTinThucDon_NguyenLieu;
        private System.Windows.Forms.DataGridView dgvThongTinThucDon_MonAn;
        private System.Windows.Forms.Button btnXuatDanhSachTheoLop;
        private System.Windows.Forms.Button btnBaoCaoNhaBep;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}