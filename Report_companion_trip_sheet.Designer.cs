namespace Army_Vechical_Entry
{
    partial class Report_companion_trip_sheet
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
            this.Vehical_Entry_RecordDataSet6 = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet6();
            this.Search_companionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search_companionsTableAdapter = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet6TableAdapters.Search_companionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_companionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Search_companionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Army_Vechical_Entry.Report_companion_tripsheet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(718, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // Vehical_Entry_RecordDataSet6
            // 
            this.Vehical_Entry_RecordDataSet6.DataSetName = "Vehical_Entry_RecordDataSet6";
            this.Vehical_Entry_RecordDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_companionsBindingSource
            // 
            this.Search_companionsBindingSource.DataMember = "Search_companions";
            this.Search_companionsBindingSource.DataSource = this.Vehical_Entry_RecordDataSet6;
            // 
            // Search_companionsTableAdapter
            // 
            this.Search_companionsTableAdapter.ClearBeforeFill = true;
            // 
            // Report_companion_trip_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 466);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_companion_trip_sheet";
            this.Text = "Report Companion Trip";
            this.Load += new System.EventHandler(this.Report_companion_trip_sheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_companionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Search_companionsBindingSource;
        private Vehical_Entry_RecordDataSet6 Vehical_Entry_RecordDataSet6;
        private Vehical_Entry_RecordDataSet6TableAdapters.Search_companionsTableAdapter Search_companionsTableAdapter;
    }
}