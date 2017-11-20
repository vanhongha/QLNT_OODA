namespace QLNT.Presentation
{
    partial class frmXepLop
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.cboLoaiLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoXepLop = new System.Windows.Forms.RadioButton();
            this.txtSiSo_LuaChon = new System.Windows.Forms.TextBox();
            this.rdoChuyenLop = new System.Windows.Forms.RadioButton();
            this.cboLoaiLop_LuaChon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNamHoc_LuaChon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLopHoc_LuaChon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPutBackAll = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPutBack = new System.Windows.Forms.Button();
            this.btnPutForwardAll = new System.Windows.Forms.Button();
            this.btnPutForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgvDanhSach.Location = new System.Drawing.Point(86, 181);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.Size = new System.Drawing.Size(458, 503);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSiSo);
            this.groupBox1.Controls.Add(this.cboLoaiLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.cboNamHoc);
            this.groupBox1.Location = new System.Drawing.Point(650, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp cần chuyển đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sỉ số lớp";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo.Location = new System.Drawing.Point(86, 142);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(366, 26);
            this.txtSiSo.TabIndex = 9;
            // 
            // cboLoaiLop
            // 
            this.cboLoaiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiLop.FormattingEnabled = true;
            this.cboLoaiLop.Location = new System.Drawing.Point(86, 74);
            this.cboLoaiLop.Name = "cboLoaiLop";
            this.cboLoaiLop.Size = new System.Drawing.Size(366, 28);
            this.cboLoaiLop.TabIndex = 5;
            this.cboLoaiLop.SelectedIndexChanged += new System.EventHandler(this.cboLoaiLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lớp học";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(86, 108);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(366, 28);
            this.cboLop.TabIndex = 6;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(86, 40);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(366, 28);
            this.cboNamHoc.TabIndex = 7;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rdoXepLop);
            this.groupBox2.Controls.Add(this.txtSiSo_LuaChon);
            this.groupBox2.Controls.Add(this.rdoChuyenLop);
            this.groupBox2.Controls.Add(this.cboLoaiLop_LuaChon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboNamHoc_LuaChon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboLopHoc_LuaChon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(86, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn sắp xếp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sỉ số lớp";
            // 
            // rdoXepLop
            // 
            this.rdoXepLop.AutoSize = true;
            this.rdoXepLop.Location = new System.Drawing.Point(97, 19);
            this.rdoXepLop.Name = "rdoXepLop";
            this.rdoXepLop.Size = new System.Drawing.Size(61, 17);
            this.rdoXepLop.TabIndex = 0;
            this.rdoXepLop.TabStop = true;
            this.rdoXepLop.Text = "Xếp lớp";
            this.rdoXepLop.UseVisualStyleBackColor = true;
            this.rdoXepLop.CheckedChanged += new System.EventHandler(this.rdoXepLop_CheckedChanged);
            // 
            // txtSiSo_LuaChon
            // 
            this.txtSiSo_LuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo_LuaChon.Location = new System.Drawing.Point(86, 144);
            this.txtSiSo_LuaChon.Name = "txtSiSo_LuaChon";
            this.txtSiSo_LuaChon.ReadOnly = true;
            this.txtSiSo_LuaChon.Size = new System.Drawing.Size(366, 26);
            this.txtSiSo_LuaChon.TabIndex = 9;
            // 
            // rdoChuyenLop
            // 
            this.rdoChuyenLop.AutoSize = true;
            this.rdoChuyenLop.Location = new System.Drawing.Point(6, 19);
            this.rdoChuyenLop.Name = "rdoChuyenLop";
            this.rdoChuyenLop.Size = new System.Drawing.Size(78, 17);
            this.rdoChuyenLop.TabIndex = 0;
            this.rdoChuyenLop.TabStop = true;
            this.rdoChuyenLop.Text = "Chuyển lớp";
            this.rdoChuyenLop.UseVisualStyleBackColor = true;
            this.rdoChuyenLop.CheckedChanged += new System.EventHandler(this.rdoChuyenLop_CheckedChanged);
            // 
            // cboLoaiLop_LuaChon
            // 
            this.cboLoaiLop_LuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiLop_LuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiLop_LuaChon.FormattingEnabled = true;
            this.cboLoaiLop_LuaChon.Location = new System.Drawing.Point(86, 76);
            this.cboLoaiLop_LuaChon.Name = "cboLoaiLop_LuaChon";
            this.cboLoaiLop_LuaChon.Size = new System.Drawing.Size(366, 28);
            this.cboLoaiLop_LuaChon.TabIndex = 5;
            this.cboLoaiLop_LuaChon.SelectedIndexChanged += new System.EventHandler(this.cboLoaiLop_LuaChon_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Năm học";
            // 
            // cboNamHoc_LuaChon
            // 
            this.cboNamHoc_LuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc_LuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNamHoc_LuaChon.FormattingEnabled = true;
            this.cboNamHoc_LuaChon.Location = new System.Drawing.Point(86, 42);
            this.cboNamHoc_LuaChon.Name = "cboNamHoc_LuaChon";
            this.cboNamHoc_LuaChon.Size = new System.Drawing.Size(366, 28);
            this.cboNamHoc_LuaChon.TabIndex = 7;
            this.cboNamHoc_LuaChon.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_LuaChon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loại lớp";
            // 
            // cboLopHoc_LuaChon
            // 
            this.cboLopHoc_LuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc_LuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopHoc_LuaChon.FormattingEnabled = true;
            this.cboLopHoc_LuaChon.Location = new System.Drawing.Point(86, 110);
            this.cboLopHoc_LuaChon.Name = "cboLopHoc_LuaChon";
            this.cboLopHoc_LuaChon.Size = new System.Drawing.Size(366, 28);
            this.cboLopHoc_LuaChon.TabIndex = 6;
            this.cboLopHoc_LuaChon.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_LuaChon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp học";
            // 
            // btnPutBackAll
            // 
            this.btnPutBackAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPutBackAll.Image = global::QLNT.Properties.Resources.icons8_double_left_50;
            this.btnPutBackAll.Location = new System.Drawing.Point(550, 361);
            this.btnPutBackAll.Name = "btnPutBackAll";
            this.btnPutBackAll.Size = new System.Drawing.Size(94, 54);
            this.btnPutBackAll.TabIndex = 1;
            this.btnPutBackAll.UseVisualStyleBackColor = true;
            this.btnPutBackAll.Click += new System.EventHandler(this.btnPutBackAll_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvKetQua.Location = new System.Drawing.Point(650, 181);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(458, 503);
            this.dgvKetQua.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnPutBack
            // 
            this.btnPutBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPutBack.Image = global::QLNT.Properties.Resources.icons8_back_50;
            this.btnPutBack.Location = new System.Drawing.Point(550, 301);
            this.btnPutBack.Name = "btnPutBack";
            this.btnPutBack.Size = new System.Drawing.Size(94, 54);
            this.btnPutBack.TabIndex = 1;
            this.btnPutBack.UseVisualStyleBackColor = true;
            this.btnPutBack.Click += new System.EventHandler(this.btnPutBack_Click);
            // 
            // btnPutForwardAll
            // 
            this.btnPutForwardAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPutForwardAll.Image = global::QLNT.Properties.Resources.icons8_double_right_50;
            this.btnPutForwardAll.Location = new System.Drawing.Point(550, 241);
            this.btnPutForwardAll.Name = "btnPutForwardAll";
            this.btnPutForwardAll.Size = new System.Drawing.Size(94, 54);
            this.btnPutForwardAll.TabIndex = 1;
            this.btnPutForwardAll.UseVisualStyleBackColor = true;
            this.btnPutForwardAll.Click += new System.EventHandler(this.btnPutForwardAll_Click);
            // 
            // btnPutForward
            // 
            this.btnPutForward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPutForward.Image = global::QLNT.Properties.Resources.icons8_forward_50;
            this.btnPutForward.Location = new System.Drawing.Point(550, 181);
            this.btnPutForward.Name = "btnPutForward";
            this.btnPutForward.Size = new System.Drawing.Size(94, 54);
            this.btnPutForward.TabIndex = 1;
            this.btnPutForward.UseVisualStyleBackColor = true;
            this.btnPutForward.Click += new System.EventHandler(this.btnPutForward_Click);
            // 
            // frmXepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPutBackAll);
            this.Controls.Add(this.btnPutBack);
            this.Controls.Add(this.btnPutForwardAll);
            this.Controls.Add(this.btnPutForward);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dgvDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXepLop";
            this.Text = "frmXepLop";
            this.Load += new System.EventHandler(this.frmXepLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnPutForward;
        private System.Windows.Forms.Button btnPutForwardAll;
        private System.Windows.Forms.Button btnPutBack;
        private System.Windows.Forms.Button btnPutBackAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoXepLop;
        private System.Windows.Forms.RadioButton rdoChuyenLop;
        private System.Windows.Forms.ComboBox cboLoaiLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtSiSo_LuaChon;
        private System.Windows.Forms.ComboBox cboLoaiLop_LuaChon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNamHoc_LuaChon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLopHoc_LuaChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}