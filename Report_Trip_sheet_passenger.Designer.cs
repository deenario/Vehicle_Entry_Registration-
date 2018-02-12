namespace Army_Vechical_Entry
{
    partial class Report_Trip_sheet_passenger
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
            this.search_passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vehical_Entry_RecordDataSet3 = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.search_passengerTableAdapter = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet3TableAdapters.search_passengerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.search_passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // search_passengerBindingSource
            // 
            this.search_passengerBindingSource.DataMember = "search_passenger";
            this.search_passengerBindingSource.DataSource = this.Vehical_Entry_RecordDataSet3;
            // 
            // Vehical_Entry_RecordDataSet3
            // 
            this.Vehical_Entry_RecordDataSet3.DataSetName = "Vehical_Entry_RecordDataSet3";
            this.Vehical_Entry_RecordDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.search_passengerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Army_Vechical_Entry.Report_Trip_sheet_passenger.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(627, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // search_passengerTableAdapter
            // 
            this.search_passengerTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Trip_sheet_passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 392);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Report_Trip_sheet_passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Report_Trip_sheet_passenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource search_passengerBindingSource;
        private Vehical_Entry_RecordDataSet3 Vehical_Entry_RecordDataSet3;
        private Vehical_Entry_RecordDataSet3TableAdapters.search_passengerTableAdapter search_passengerTableAdapter;
    }
}