namespace QLNT.Presentation
{
    partial class frmBaoCaoSucKhoe
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
            this.GetSucKhoeTheoThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucKhoeDataSet = new QLNT.SucKhoeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getSucKhoeTheoThangTableAdapter = new QLNT.SucKhoeDataSetTableAdapters.GetSucKhoeTheoThangTableAdapter();
            this.sucKhoeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetSucKhoeTheoThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucKhoeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucKhoeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetSucKhoeTheoThangBindingSource
            // 
            this.GetSucKhoeTheoThangBindingSource.DataMember = "GetSucKhoeTheoThang";
            this.GetSucKhoeTheoThangBindingSource.DataSource = this.sucKhoeDataSet;
            // 
            // sucKhoeDataSet
            // 
            this.sucKhoeDataSet.DataSetName = "SucKhoeDataSet";
            this.sucKhoeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SucKhoeDataSet";
            reportDataSource1.Value = this.GetSucKhoeTheoThangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNT.Presentation.BaoCaoSucKhoe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(688, 648);
            this.reportViewer1.TabIndex = 0;
            // 
            // getSucKhoeTheoThangTableAdapter
            // 
            this.getSucKhoeTheoThangTableAdapter.ClearBeforeFill = true;
            // 
            // sucKhoeDataSetBindingSource
            // 
            this.sucKhoeDataSetBindingSource.DataSource = this.sucKhoeDataSet;
            this.sucKhoeDataSetBindingSource.Position = 0;
            // 
            // frmBaoCaoSucKhoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 648);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoSucKhoe";
            this.Text = "frmBaoCaoSucKhoe";
            this.Load += new System.EventHandler(this.frmBaoCaoSucKhoe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetSucKhoeTheoThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucKhoeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucKhoeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SucKhoeDataSet sucKhoeDataSet;
        private SucKhoeDataSetTableAdapters.GetSucKhoeTheoThangTableAdapter getSucKhoeTheoThangTableAdapter;
        private System.Windows.Forms.BindingSource GetSucKhoeTheoThangBindingSource;
        private System.Windows.Forms.BindingSource sucKhoeDataSetBindingSource;
    }
}