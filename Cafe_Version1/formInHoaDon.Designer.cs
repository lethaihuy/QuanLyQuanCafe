namespace Cafe_Version1
{
    partial class formInHoaDon
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
            this.USP_InHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CAFE_VERSION_1DataSet = new Cafe_Version1.CAFE_VERSION_1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_InHoaDonTableAdapter = new Cafe_Version1.CAFE_VERSION_1DataSetTableAdapters.USP_InHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_InHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAFE_VERSION_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_InHoaDonBindingSource
            // 
            this.USP_InHoaDonBindingSource.DataMember = "USP_InHoaDon";
            this.USP_InHoaDonBindingSource.DataSource = this.CAFE_VERSION_1DataSet;
            // 
            // CAFE_VERSION_1DataSet
            // 
            this.CAFE_VERSION_1DataSet.DataSetName = "CAFE_VERSION_1DataSet";
            this.CAFE_VERSION_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_InHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cafe_Version1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(490, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_InHoaDonTableAdapter
            // 
            this.USP_InHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // formInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 478);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formInHoaDon";
            this.Text = "formInHoaDon";
            this.Load += new System.EventHandler(this.formInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_InHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAFE_VERSION_1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_InHoaDonBindingSource;
        private CAFE_VERSION_1DataSet CAFE_VERSION_1DataSet;
        private CAFE_VERSION_1DataSetTableAdapters.USP_InHoaDonTableAdapter USP_InHoaDonTableAdapter;
    }
}