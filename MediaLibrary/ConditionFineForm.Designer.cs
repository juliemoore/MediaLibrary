namespace MediaLibrary
{
    partial class ConditionFineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionFineForm));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.damageFeeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.damageFeeViewTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.DamageFeeViewTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.damageFeeViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.damageFeeViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.damageFeeViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeBtn = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingNavigator)).BeginInit();
            this.damageFeeViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // damageFeeViewBindingSource
            // 
            this.damageFeeViewBindingSource.DataMember = "DamageFeeView";
            this.damageFeeViewBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // damageFeeViewTableAdapter
            // 
            this.damageFeeViewTableAdapter.ClearBeforeFill = true;
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
            // damageFeeViewBindingNavigator
            // 
            this.damageFeeViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.damageFeeViewBindingNavigator.BindingSource = this.damageFeeViewBindingSource;
            this.damageFeeViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.damageFeeViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.damageFeeViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.damageFeeViewBindingNavigatorSaveItem});
            this.damageFeeViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.damageFeeViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.damageFeeViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.damageFeeViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.damageFeeViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.damageFeeViewBindingNavigator.Name = "damageFeeViewBindingNavigator";
            this.damageFeeViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.damageFeeViewBindingNavigator.Size = new System.Drawing.Size(600, 25);
            this.damageFeeViewBindingNavigator.TabIndex = 0;
            this.damageFeeViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // damageFeeViewBindingNavigatorSaveItem
            // 
            this.damageFeeViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.damageFeeViewBindingNavigatorSaveItem.Enabled = false;
            this.damageFeeViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("damageFeeViewBindingNavigatorSaveItem.Image")));
            this.damageFeeViewBindingNavigatorSaveItem.Name = "damageFeeViewBindingNavigatorSaveItem";
            this.damageFeeViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.damageFeeViewBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // damageFeeViewDataGridView
            // 
            this.damageFeeViewDataGridView.AutoGenerateColumns = false;
            this.damageFeeViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damageFeeViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.damageFeeViewDataGridView.DataSource = this.damageFeeViewBindingSource;
            this.damageFeeViewDataGridView.Location = new System.Drawing.Point(29, 43);
            this.damageFeeViewDataGridView.Name = "damageFeeViewDataGridView";
            this.damageFeeViewDataGridView.Size = new System.Drawing.Size(542, 220);
            this.damageFeeViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatronIDFK";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatronIDFK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CheckoutID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CheckoutID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FineAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "FineAmount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaidAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "PaidAmount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaidDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaidDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(350, 275);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(175, 275);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConditionFineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 310);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.damageFeeViewDataGridView);
            this.Controls.Add(this.damageFeeViewBindingNavigator);
            this.Name = "ConditionFineForm";
            this.Text = "Condition and Fines";
            this.Load += new System.EventHandler(this.ConditionFineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingNavigator)).EndInit();
            this.damageFeeViewBindingNavigator.ResumeLayout(false);
            this.damageFeeViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource damageFeeViewBindingSource;
        private MediaLibraryDataSetTableAdapters.DamageFeeViewTableAdapter damageFeeViewTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator damageFeeViewBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton damageFeeViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView damageFeeViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btnDetails;
    }
}