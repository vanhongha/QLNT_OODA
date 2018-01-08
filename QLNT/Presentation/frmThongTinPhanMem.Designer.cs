namespace QLNT.Presentation
{
    partial class frmThongTinPhanMem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinPhanMem));
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(139, 96);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(239, 67);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Tác giả:            Văn Hồng Hà \r\n                          Phạm Nữ Tuyết An\r\n   " +
    "                       Văn Thị Hồng Hạnh \r\n                          Nông Thị Lệ" +
    "";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(139, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(259, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Ngày release:   08/01/2018";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(139, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(259, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Version:            2.0";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(139, 13);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(259, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "PHẦN MỀM QUẢN LÝ MẦM NON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "_______________________________________________________________";
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(171, 208);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(79, 36);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNT.Properties.Resources.Emojione_1F3EB_svg;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmThongTinPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 256);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinPhanMem";
            this.Text = "Thông tin phần mềm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}