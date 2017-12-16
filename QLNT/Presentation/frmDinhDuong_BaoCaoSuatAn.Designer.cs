namespace QLNT.Presentation
{
    partial class frmDinhDuong_BaoCaoSuatAn
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.layDanhSachThongTinSuatAnTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucDonDataSet = new QLNT.ThucDonDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.layDanhSachThongTinSuatAnTheoLopTableAdapter = new QLNT.ThucDonDataSetTableAdapters.LayDanhSachThongTinSuatAnTheoLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachThongTinSuatAnTheoLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // layDanhSachThongTinSuatAnTheoLopBindingSource
            // 
            this.layDanhSachThongTinSuatAnTheoLopBindingSource.DataMember = "LayDanhSachThongTinSuatAnTheoLop";
            this.layDanhSachThongTinSuatAnTheoLopBindingSource.DataSource = this.thucDonDataSet;
            // 
            // thucDonDataSet
            // 
            this.thucDonDataSet.DataSetName = "ThucDonDataSet";
            this.thucDonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.layDanhSachThongTinSuatAnTheoLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNT.Presentation.BaoCaoSuatAn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(360, 465);
            this.reportViewer1.TabIndex = 0;
            // 
            // layDanhSachThongTinSuatAnTheoLopTableAdapter
            // 
            this.layDanhSachThongTinSuatAnTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // frmDinhDuong_BaoCaoSuatAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDinhDuong_BaoCaoSuatAn";
            this.Text = "frmDinhDuong_BaoCaoSuatAn";
            this.Load += new System.EventHandler(this.frmDinhDuong_BaoCaoSuatAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachThongTinSuatAnTheoLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource layDanhSachThongTinSuatAnTheoLopBindingSource;
        private ThucDonDataSet thucDonDataSet;
        private ThucDonDataSetTableAdapters.LayDanhSachThongTinSuatAnTheoLopTableAdapter layDanhSachThongTinSuatAnTheoLopTableAdapter;
    }
}