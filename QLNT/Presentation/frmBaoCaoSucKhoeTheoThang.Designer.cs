namespace QLNT.Presentation
{
    partial class frmBaoCaoSucKhoeTheoThang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sucKhoeTheoThangDataset = new QLNT.SucKhoeTheoThangDataset();
            this.getSucKhoeTrongKhoangThoiGianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSucKhoeTrongKhoangThoiGianTableAdapter = new QLNT.SucKhoeTheoThangDatasetTableAdapters.GetSucKhoeTrongKhoangThoiGianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sucKhoeTheoThangDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSucKhoeTrongKhoangThoiGianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SucKhoeTheoThangDS";
            reportDataSource1.Value = this.getSucKhoeTrongKhoangThoiGianBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNT.Presentation.BaoCaoSucKhoeTheoThang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(635, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // sucKhoeTheoThangDataset
            // 
            this.sucKhoeTheoThangDataset.DataSetName = "SucKhoeTheoThangDataset";
            this.sucKhoeTheoThangDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSucKhoeTrongKhoangThoiGianBindingSource
            // 
            this.getSucKhoeTrongKhoangThoiGianBindingSource.DataMember = "GetSucKhoeTrongKhoangThoiGian";
            this.getSucKhoeTrongKhoangThoiGianBindingSource.DataSource = this.sucKhoeTheoThangDataset;
            // 
            // getSucKhoeTrongKhoangThoiGianTableAdapter
            // 
            this.getSucKhoeTrongKhoangThoiGianTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoSucKhoeTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 596);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoSucKhoeTheoThang";
            this.Text = "frmBaoCaoSucKhoeTheoThang";
            this.Load += new System.EventHandler(this.frmBaoCaoSucKhoeTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sucKhoeTheoThangDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSucKhoeTrongKhoangThoiGianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getSucKhoeTrongKhoangThoiGianBindingSource;
        private SucKhoeTheoThangDataset sucKhoeTheoThangDataset;
        private SucKhoeTheoThangDatasetTableAdapters.GetSucKhoeTrongKhoangThoiGianTableAdapter getSucKhoeTrongKhoangThoiGianTableAdapter;
    }
}