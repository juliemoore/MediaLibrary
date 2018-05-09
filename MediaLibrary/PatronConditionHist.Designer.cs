namespace MediaLibrary
{
    partial class PatronConditionHist
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PatronConditionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PatronConditionViewTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronConditionViewTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatronConditionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaLibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PatronConditionViewBindingSource
            // 
            this.PatronConditionViewBindingSource.DataMember = "PatronConditionView";
            this.PatronConditionViewBindingSource.DataSource = this.MediaLibraryDataSet;
            // 
            // MediaLibraryDataSet
            // 
            this.MediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.MediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PatronConditionViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MediaLibrary.PatronConditionHist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 434);
            this.reportViewer1.TabIndex = 0;
            // 
            // PatronConditionViewTableAdapter
            // 
            this.PatronConditionViewTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PatronConditionHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PatronConditionHist";
            this.Text = "PatronConditionHist";
            this.Load += new System.EventHandler(this.PatronConditionHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatronConditionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaLibraryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PatronConditionViewBindingSource;
        private MediaLibraryDataSet MediaLibraryDataSet;
        private MediaLibraryDataSetTableAdapters.PatronConditionViewTableAdapter PatronConditionViewTableAdapter;
        private System.Windows.Forms.Button btnClose;
    }
}