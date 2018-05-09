namespace MediaLibrary
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.patronCheckoutsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.patronCheckoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronCheckoutsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.patronCheckoutsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingNavigator)).BeginInit();
            this.patronCheckoutsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patronCheckoutsBindingNavigator
            // 
            this.patronCheckoutsBindingNavigator.AddNewItem = null;
            this.patronCheckoutsBindingNavigator.CountItem = null;
            this.patronCheckoutsBindingNavigator.DeleteItem = null;
            this.patronCheckoutsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem});
            this.patronCheckoutsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patronCheckoutsBindingNavigator.MoveFirstItem = null;
            this.patronCheckoutsBindingNavigator.MoveLastItem = null;
            this.patronCheckoutsBindingNavigator.MoveNextItem = null;
            this.patronCheckoutsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patronCheckoutsBindingNavigator.Name = "patronCheckoutsBindingNavigator";
            this.patronCheckoutsBindingNavigator.PositionItem = null;
            this.patronCheckoutsBindingNavigator.Size = new System.Drawing.Size(718, 25);
            this.patronCheckoutsBindingNavigator.TabIndex = 0;
            this.patronCheckoutsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patronCheckoutsBindingSource
            // 
            this.patronCheckoutsBindingSource.DataMember = "PatronCheckouts";
            this.patronCheckoutsBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // patronCheckoutsTableAdapter
            // 
            this.patronCheckoutsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patronCheckoutsDataGridView
            // 
            this.patronCheckoutsDataGridView.AutoGenerateColumns = false;
            this.patronCheckoutsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronCheckoutsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.patronCheckoutsDataGridView.DataSource = this.patronCheckoutsBindingSource;
            this.patronCheckoutsDataGridView.Location = new System.Drawing.Point(37, 28);
            this.patronCheckoutsDataGridView.Name = "patronCheckoutsDataGridView";
            this.patronCheckoutsDataGridView.Size = new System.Drawing.Size(644, 220);
            this.patronCheckoutsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatronID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatronID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatronFirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatronFirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatronLastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatronLastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatronAddress1";
            this.dataGridViewTextBoxColumn4.HeaderText = "PatronAddress1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PatronAddress2";
            this.dataGridViewTextBoxColumn5.HeaderText = "PatronAddress2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PatronCity";
            this.dataGridViewTextBoxColumn6.HeaderText = "PatronCity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PatronState";
            this.dataGridViewTextBoxColumn7.HeaderText = "PatronState";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PatronZipcode";
            this.dataGridViewTextBoxColumn8.HeaderText = "PatronZipcode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PatronPhone";
            this.dataGridViewTextBoxColumn9.HeaderText = "PatronPhone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PatronEmail";
            this.dataGridViewTextBoxColumn10.HeaderText = "PatronEmail";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "JoinDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "JoinDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "InactiveDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "InactiveDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CheckoutID";
            this.dataGridViewTextBoxColumn13.HeaderText = "CheckoutID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MediaItemIDFK";
            this.dataGridViewTextBoxColumn14.HeaderText = "MediaItemIDFK";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PatronIDFK";
            this.dataGridViewTextBoxColumn15.HeaderText = "PatronIDFK";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "OutDate";
            this.dataGridViewTextBoxColumn16.HeaderText = "OutDate";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn17.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ReturnDate";
            this.dataGridViewTextBoxColumn18.HeaderText = "ReturnDate";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "OutConditionIDFK";
            this.dataGridViewTextBoxColumn19.HeaderText = "OutConditionIDFK";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ReturnConditionIDFK";
            this.dataGridViewTextBoxColumn20.HeaderText = "ReturnConditionIDFK";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 322);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.patronCheckoutsDataGridView);
            this.Controls.Add(this.patronCheckoutsBindingNavigator);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingNavigator)).EndInit();
            this.patronCheckoutsBindingNavigator.ResumeLayout(false);
            this.patronCheckoutsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator patronCheckoutsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource patronCheckoutsBindingSource;
        private MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter patronCheckoutsTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patronCheckoutsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.Button btnClose;
    }
}