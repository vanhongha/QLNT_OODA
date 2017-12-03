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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboBuoiAD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgay_Loc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTietThucDon = new System.Windows.Forms.DataGridView();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
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
            this.cboBuoiAD.Location = new System.Drawing.Point(339, 8);
            this.cboBuoiAD.Name = "cboBuoiAD";
            this.cboBuoiAD.Size = new System.Drawing.Size(123, 24);
            this.cboBuoiAD.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(2, 11);
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
            this.label5.Location = new System.Drawing.Point(241, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Buổi Áp Dụng: ";
            // 
            // dtpNgay_Loc
            // 
            this.dtpNgay_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay_Loc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_Loc.Location = new System.Drawing.Point(104, 8);
            this.dtpNgay_Loc.Name = "dtpNgay_Loc";
            this.dtpNgay_Loc.Size = new System.Drawing.Size(108, 22);
            this.dtpNgay_Loc.TabIndex = 100;
            this.dtpNgay_Loc.Value = new System.DateTime(2017, 5, 31, 20, 12, 25, 0);
            this.dtpNgay_Loc.ValueChanged += new System.EventHandler(this.dtpNgay_Loc_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbAll);
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 273);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH LỚP";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(36, 29);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(15, 14);
            this.ckbAll.TabIndex = 88;
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(16, 21);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(606, 242);
            this.dgvLop.TabIndex = 96;
            // 
            // cboLop
            // 
            this.cboLop.AccessibleDescription = "";
            this.cboLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(756, 8);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 24);
            this.cboLop.TabIndex = 105;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(718, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 106;
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
            this.cboLoaiLop.Location = new System.Drawing.Point(569, 7);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiLop.TabIndex = 103;
            this.cboLoaiLop.SelectedIndexChanged += new System.EventHandler(this.cboLoaiLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(503, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Loại Lớp:";
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
            this.dgvChiTietThucDon.Location = new System.Drawing.Point(664, 49);
            this.dgvChiTietThucDon.Name = "dgvChiTietThucDon";
            this.dgvChiTietThucDon.ReadOnly = true;
            this.dgvChiTietThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietThucDon.Size = new System.Drawing.Size(500, 193);
            this.dgvChiTietThucDon.TabIndex = 108;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AllowUserToDeleteRows = false;
            this.dgvThucDon.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Location = new System.Drawing.Point(41, 49);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(606, 193);
            this.dgvThucDon.TabIndex = 109;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick_1);
            // 
            // frmDinhDuong_ApDungThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 528);
            this.Controls.Add(this.dgvThucDon);
            this.Controls.Add(this.dgvChiTietThucDon);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboLoaiLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuoiAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgay_Loc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDinhDuong_ApDungThucDon";
            this.Text = "Sáng";
            this.Load += new System.EventHandler(this.frmDinhDuong_ApDungThucDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBuoiAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgay_Loc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietThucDon;
        private System.Windows.Forms.DataGridView dgvThucDon;
    }
}