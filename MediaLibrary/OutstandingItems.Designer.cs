namespace MediaLibrary
{
    partial class OutstandingItems
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PatronCheckoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PatronCheckoutsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatronCheckoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaLibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PatronCheckoutsBindingSource
            // 
            this.PatronCheckoutsBindingSource.DataMember = "PatronCheckouts";
            this.PatronCheckoutsBindingSource.DataSource = this.MediaLibraryDataSet;
            // 
            // MediaLibraryDataSet
            // 
            this.MediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.MediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.PatronCheckoutsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MediaLibrary.OutstandingItems.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // PatronCheckoutsTableAdapter
            // 
            this.PatronCheckoutsTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OutstandingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OutstandingItems";
            this.Text = "OutstandingItems";
            this.Load += new System.EventHandler(this.OutstandingItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatronCheckoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaLibraryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PatronCheckoutsBindingSource;
        private MediaLibraryDataSet MediaLibraryDataSet;
        private MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter PatronCheckoutsTableAdapter;
        private System.Windows.Forms.Button btnClose;
    }
}