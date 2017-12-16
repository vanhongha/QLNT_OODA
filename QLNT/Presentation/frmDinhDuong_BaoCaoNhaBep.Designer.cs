namespace QLNT.Presentation
{
    partial class frmDinhDuong_BaoCaoNhaBep
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.layDanhSachNguyenLieuTheoBuoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucDonDataSet = new QLNT.ThucDonDataSet();
            this.layDanhSachMonAnTheoBuoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.layDanhSachNguyenLieuTheoBuoiTableAdapter = new QLNT.ThucDonDataSetTableAdapters.LayDanhSachNguyenLieuTheoBuoiTableAdapter();
            this.layDanhSachMonAnTheoBuoiTableAdapter = new QLNT.ThucDonDataSetTableAdapters.LayDanhSachMonAnTheoBuoiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachNguyenLieuTheoBuoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachMonAnTheoBuoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layDanhSachNguyenLieuTheoBuoiBindingSource
            // 
            this.layDanhSachNguyenLieuTheoBuoiBindingSource.DataMember = "LayDanhSachNguyenLieuTheoBuoi";
            this.layDanhSachNguyenLieuTheoBuoiBindingSource.DataSource = this.thucDonDataSet;
            // 
            // thucDonDataSet
            // 
            this.thucDonDataSet.DataSetName = "ThucDonDataSet";
            this.thucDonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layDanhSachMonAnTheoBuoiBindingSource
            // 
            this.layDanhSachMonAnTheoBuoiBindingSource.DataMember = "LayDanhSachMonAnTheoBuoi";
            this.layDanhSachMonAnTheoBuoiBindingSource.DataSource = this.thucDonDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.layDanhSachNguyenLieuTheoBuoiBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.layDanhSachMonAnTheoBuoiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNT.Presentation.BaoCaoNhaBep.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(359, 612);
            this.reportViewer1.TabIndex = 0;
            // 
            // layDanhSachNguyenLieuTheoBuoiTableAdapter
            // 
            this.layDanhSachNguyenLieuTheoBuoiTableAdapter.ClearBeforeFill = true;
            // 
            // layDanhSachMonAnTheoBuoiTableAdapter
            // 
            this.layDanhSachMonAnTheoBuoiTableAdapter.ClearBeforeFill = true;
            // 
            // frmDinhDuong_BaoCaoNhaBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 626);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDinhDuong_BaoCaoNhaBep";
            this.Text = "frmDinhDuong_BaoCaoNhaBep";
            this.Load += new System.EventHandler(this.frmDinhDuong_BaoCaoNhaBep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachNguyenLieuTheoBuoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachMonAnTheoBuoiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource layDanhSachNguyenLieuTheoBuoiBindingSource;
        private ThucDonDataSet thucDonDataSet;
        private System.Windows.Forms.BindingSource layDanhSachMonAnTheoBuoiBindingSource;
        private ThucDonDataSetTableAdapters.LayDanhSachNguyenLieuTheoBuoiTableAdapter layDanhSachNguyenLieuTheoBuoiTableAdapter;
        private ThucDonDataSetTableAdapters.LayDanhSachMonAnTheoBuoiTableAdapter layDanhSachMonAnTheoBuoiTableAdapter;
    }
}