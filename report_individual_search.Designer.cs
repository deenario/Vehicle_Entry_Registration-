namespace Army_Vechical_Entry
{
    partial class report_individual_search
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
            this.Search_Person_CNICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vehical_Entry_RecordDataSet2 = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Search_Person_CNICTableAdapter = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet2TableAdapters.Search_Person_CNICTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Person_CNICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Person_CNICBindingSource
            // 
            this.Search_Person_CNICBindingSource.DataMember = "Search_Person_CNIC";
            this.Search_Person_CNICBindingSource.DataSource = this.Vehical_Entry_RecordDataSet2;
            // 
            // Vehical_Entry_RecordDataSet2
            // 
            this.Vehical_Entry_RecordDataSet2.DataSetName = "Vehical_Entry_RecordDataSet2";
            this.Vehical_Entry_RecordDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Search_Person_CNICBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Army_Vechical_Entry.Report_Individual_Search.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(757, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // Search_Person_CNICTableAdapter
            // 
            this.Search_Person_CNICTableAdapter.ClearBeforeFill = true;
            // 
            // report_individual_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 375);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "report_individual_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.report_individual_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Search_Person_CNICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Search_Person_CNICBindingSource;
        private Vehical_Entry_RecordDataSet2 Vehical_Entry_RecordDataSet2;
        private Vehical_Entry_RecordDataSet2TableAdapters.Search_Person_CNICTableAdapter Search_Person_CNICTableAdapter;

    }
}