namespace Army_Vechical_Entry
{
    partial class Individual_report_form
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
            this.Vehical_Entry_RecordDataSet5 = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet5();
            this.Search_PersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search_PersonTableAdapter = new Army_Vechical_Entry.Vehical_Entry_RecordDataSet5TableAdapters.Search_PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_PersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Search_PersonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Army_Vechical_Entry.individual_receipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(301, 390);
            this.reportViewer1.TabIndex = 0;
            // 
            // Vehical_Entry_RecordDataSet5
            // 
            this.Vehical_Entry_RecordDataSet5.DataSetName = "Vehical_Entry_RecordDataSet5";
            this.Vehical_Entry_RecordDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Search_PersonBindingSource
            // 
            this.Search_PersonBindingSource.DataMember = "Search_Person";
            this.Search_PersonBindingSource.DataSource = this.Vehical_Entry_RecordDataSet5;
            // 
            // Search_PersonTableAdapter
            // 
            this.Search_PersonTableAdapter.ClearBeforeFill = true;
            // 
            // Individual_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 390);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Individual_report_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individual Report";
            this.Load += new System.EventHandler(this.Individual_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vehical_Entry_RecordDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_PersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Search_PersonBindingSource;
        private Vehical_Entry_RecordDataSet5 Vehical_Entry_RecordDataSet5;
        private Vehical_Entry_RecordDataSet5TableAdapters.Search_PersonTableAdapter Search_PersonTableAdapter;
    }
}