namespace Army_Vechical_Entry
{
    partial class recipet_form
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
            this.Report_QueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vehical_Entry_RecordDataSet = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Report_QueryTableAdapter = new Army_Vechical_Entry.Vehical_Entry_RecordDataSetTableAdapters.Report_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Report_QueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Report_QueryBindingSource
            // 
            this.Report_QueryBindingSource.DataMember = "Report_Query";
            this.Report_QueryBindingSource.DataSource = this.Vehical_Entry_RecordDataSet;
            // 
            // Vehical_Entry_RecordDataSet
            // 
            this.Vehical_Entry_RecordDataSet.DataSetName = "Vehical_Entry_RecordDataSet";
            this.Vehical_Entry_RecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report_QueryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Army_Vechical_Entry.ReportToken.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(291, 438);
            this.reportViewer1.TabIndex = 0;
            // 
            // Report_QueryTableAdapter
            // 
            this.Report_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // recipet_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 438);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "recipet_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.recipet_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report_QueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Report_QueryBindingSource;
        private Vehical_Entry_RecordDataSet Vehical_Entry_RecordDataSet;
        private Vehical_Entry_RecordDataSetTableAdapters.Report_QueryTableAdapter Report_QueryTableAdapter;
    }
}