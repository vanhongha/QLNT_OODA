namespace QLNT.Presentation
{
    partial class frmBienLaiHocPhi
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
            this.GetInfoBienlaiHocPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bienLaiHocPhiDataSet = new QLNT.BienLaiHocPhiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bienLaiHocPhiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getInfoBienLaiHocPhiTableAdapter = new QLNT.BienLaiHocPhiDataSetTableAdapters.GetInfoBienlaiHocPhiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetInfoBienlaiHocPhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienLaiHocPhiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienLaiHocPhiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetInfoBienlaiHocPhiBindingSource
            // 
            this.GetInfoBienlaiHocPhiBindingSource.DataMember = "GetInfoBienlaiHocPhi";
            this.GetInfoBienlaiHocPhiBindingSource.DataSource = this.bienLaiHocPhiDataSet;
            // 
            // bienLaiHocPhiDataSet
            // 
            this.bienLaiHocPhiDataSet.DataSetName = "BienLaiHocPhiDataSet";
            this.bienLaiHocPhiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BienLaiHocPhiDataSet";
            reportDataSource1.Value = this.GetInfoBienlaiHocPhiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNT.Presentation.BienLaiThuHocPhi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 814);
            this.reportViewer1.TabIndex = 0;
            // 
            // bienLaiHocPhiDataSetBindingSource
            // 
            this.bienLaiHocPhiDataSetBindingSource.DataSource = this.bienLaiHocPhiDataSet;
            this.bienLaiHocPhiDataSetBindingSource.Position = 0;
            // 
            // getInfoBienLaiHocPhiTableAdapter
            // 
            this.getInfoBienLaiHocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // frmBienLaiHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 814);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBienLaiHocPhi";
            this.Text = "Biên lai học phí";
            this.Load += new System.EventHandler(this.frmBienLaiHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetInfoBienlaiHocPhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienLaiHocPhiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bienLaiHocPhiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BienLaiHocPhiDataSet bienLaiHocPhiDataSet;
        private System.Windows.Forms.BindingSource bienLaiHocPhiDataSetBindingSource;
        private BienLaiHocPhiDataSetTableAdapters.GetInfoBienlaiHocPhiTableAdapter getInfoBienLaiHocPhiTableAdapter;
        private System.Windows.Forms.BindingSource GetInfoBienlaiHocPhiBindingSource;
    }
}