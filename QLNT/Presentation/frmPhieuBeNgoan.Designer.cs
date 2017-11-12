namespace QLNT.Presentation
{
    partial class frmPhieuBeNgoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuan3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuan4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(676, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp theo dõi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHS,
            this.clTenHS,
            this.clTuan1,
            this.clTuan2,
            this.clTuan3,
            this.clTuan4,
            this.clThang,
            this.clNhanXet});
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 462);
            this.dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clMaHS
            // 
            this.clMaHS.HeaderText = "Mã học sinh";
            this.clMaHS.MinimumWidth = 50;
            this.clMaHS.Name = "clMaHS";
            this.clMaHS.ReadOnly = true;
            this.clMaHS.Width = 120;
            // 
            // clTenHS
            // 
            this.clTenHS.HeaderText = "Tên học sinh";
            this.clTenHS.MinimumWidth = 50;
            this.clTenHS.Name = "clTenHS";
            this.clTenHS.ReadOnly = true;
            this.clTenHS.Width = 200;
            // 
            // clTuan1
            // 
            this.clTuan1.HeaderText = "Phiếu BN tuần 1";
            this.clTuan1.Name = "clTuan1";
            // 
            // clTuan2
            // 
            this.clTuan2.HeaderText = "Phiếu BN tuần 2";
            this.clTuan2.Name = "clTuan2";
            // 
            // clTuan3
            // 
            this.clTuan3.HeaderText = "Phiếu BN tuần 3";
            this.clTuan3.Name = "clTuan3";
            // 
            // clTuan4
            // 
            this.clTuan4.HeaderText = "Phiếu BN tuần 4";
            this.clTuan4.Name = "clTuan4";
            // 
            // clThang
            // 
            this.clThang.HeaderText = "Phiếu BN Tháng";
            this.clThang.Name = "clThang";
            // 
            // clNhanXet
            // 
            this.clNhanXet.HeaderText = "Nhận xét Tháng";
            this.clNhanXet.Name = "clNhanXet";
            // 
            // frmPhieuBeNgoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmPhieuBeNgoan";
            this.Size = new System.Drawing.Size(1097, 589);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuan3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuan4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhanXet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
