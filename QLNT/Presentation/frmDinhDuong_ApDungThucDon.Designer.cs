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
            this.cboBuoiAD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgay_Loc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMonPhu4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMonPhu2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMonPhu1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMonChinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMonPhu3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMonPhu5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.cboBuoiAD.Location = new System.Drawing.Point(366, 6);
            this.cboBuoiAD.Name = "cboBuoiAD";
            this.cboBuoiAD.Size = new System.Drawing.Size(106, 24);
            this.cboBuoiAD.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Ngày áp dụng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(268, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Buổi Áp Dụng: ";
            // 
            // dtpNgay_Loc
            // 
            this.dtpNgay_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay_Loc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_Loc.Location = new System.Drawing.Point(122, 6);
            this.dtpNgay_Loc.Name = "dtpNgay_Loc";
            this.dtpNgay_Loc.Size = new System.Drawing.Size(121, 22);
            this.dtpNgay_Loc.TabIndex = 100;
            this.dtpNgay_Loc.Value = new System.DateTime(2017, 5, 31, 20, 12, 25, 0);
            this.dtpNgay_Loc.ValueChanged += new System.EventHandler(this.dtpNgay_Loc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(717, 11);
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
            this.cboLoaiLop.Location = new System.Drawing.Point(568, 6);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiLop.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(499, 9);
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
            this.cboLop.Location = new System.Drawing.Point(757, 6);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(106, 24);
            this.cboLop.TabIndex = 114;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(7, 21);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(552, 203);
            this.dgvLop.TabIndex = 98;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(622, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 203);
            this.dataGridView1.TabIndex = 99;
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(26, 28);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(15, 14);
            this.ckbAll.TabIndex = 129;
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(565, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 34);
            this.btnAdd.TabIndex = 130;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(565, 82);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(51, 34);
            this.btnAddAll.TabIndex = 131;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(565, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(51, 34);
            this.btnRemove.TabIndex = 132;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(565, 170);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(51, 34);
            this.btnRemoveAll.TabIndex = 133;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveAll);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAddAll);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.ckbAll);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 225);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH LỚP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboMonPhu4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboMonPhu5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboMonPhu2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboMonPhu3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboMonPhu1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboMonChinh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(23, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1155, 84);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN MÓN ĂN";
            // 
            // cboMonPhu4
            // 
            this.cboMonPhu4.AccessibleDescription = "";
            this.cboMonPhu4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMonPhu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonPhu4.FormattingEnabled = true;
            this.cboMonPhu4.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboMonPhu4.Location = new System.Drawing.Point(547, 25);
            this.cboMonPhu4.Name = "cboMonPhu4";
            this.cboMonPhu4.Size = new System.Drawing.Size(123, 24);
            this.cboMonPhu4.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(477, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 139;
            this.label9.Text = "Món phụ 4: ";
            // 
            // cboMonPhu2
            // 
            this.cboMonPhu2.AccessibleDescription = "";
            this.cboMonPhu2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMonPhu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonPhu2.FormattingEnabled = true;
            this.cboMonPhu2.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboMonPhu2.Location = new System.Drawing.Point(317, 25);
            this.cboMonPhu2.Name = "cboMonPhu2";
            this.cboMonPhu2.Size = new System.Drawing.Size(123, 24);
            this.cboMonPhu2.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(247, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 135;
            this.label8.Text = "Món phụ 2: ";
            // 
            // cboMonPhu1
            // 
            this.cboMonPhu1.AccessibleDescription = "";
            this.cboMonPhu1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMonPhu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonPhu1.FormattingEnabled = true;
            this.cboMonPhu1.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboMonPhu1.Location = new System.Drawing.Point(90, 51);
            this.cboMonPhu1.Name = "cboMonPhu1";
            this.cboMonPhu1.Size = new System.Drawing.Size(123, 24);
            this.cboMonPhu1.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 131;
            this.label3.Text = "Món phụ 1: ";
            // 
            // cboMonChinh
            // 
            this.cboMonChinh.AccessibleDescription = "";
            this.cboMonChinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMonChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonChinh.FormattingEnabled = true;
            this.cboMonChinh.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboMonChinh.Location = new System.Drawing.Point(90, 22);
            this.cboMonChinh.Name = "cboMonChinh";
            this.cboMonChinh.Size = new System.Drawing.Size(123, 24);
            this.cboMonChinh.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 129;
            this.label6.Text = "Món chính: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(247, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 133;
            this.label7.Text = "Món phụ 3: ";
            // 
            // cboMonPhu3
            // 
            this.cboMonPhu3.AccessibleDescription = "";
            this.cboMonPhu3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMonPhu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonPhu3.FormattingEnabled = true;
            this.cboMonPhu3.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboMonPhu3.Location = new System.Drawing.Point(317, 54);
            this.cboMonPhu3.Name = "cboMonPhu3";
            this.cboMonPhu3.Size = new System.Drawing.Size(123, 24);
            this.cboMonPhu3.TabIndex = 134;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(477, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 137;
            this.label10.Text = "Món phụ 5: ";
            // 
            // cboMonPhu5
            // 
            this.cboMonPhu5.AccessibleDescription = "";
            this.cboMonPhu5.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMonPhu5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonPhu5.FormattingEnabled = true;
            this.cboMonPhu5.Items.AddRange(new object[] {
            "Sáng",
            "Trưa",
            "Chiều"});
            this.cboMonPhu5.Location = new System.Drawing.Point(547, 54);
            this.cboMonPhu5.Name = "cboMonPhu5";
            this.cboMonPhu5.Size = new System.Drawing.Size(123, 24);
            this.cboMonPhu5.TabIndex = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(694, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 142;
            this.label12.Text = "Tổng năng lượng:  0";
            // 
            // frmDinhDuong_ApDungThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLoaiLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboBuoiAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgay_Loc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDinhDuong_ApDungThucDon";
            this.Text = "Sáng";
            this.Load += new System.EventHandler(this.frmDinhDuong_ApDungThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMonPhu4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMonPhu5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMonPhu2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMonPhu3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMonPhu1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMonChinh;
        private System.Windows.Forms.Label label6;
    }
}