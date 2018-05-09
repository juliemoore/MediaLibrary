namespace MediaLibrary
{
    partial class MediaType
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
            System.Windows.Forms.Label mediaTypeIDLabel;
            System.Windows.Forms.Label mediaTypeLabel;
            System.Windows.Forms.Label mediaDscrpLabel;
            System.Windows.Forms.Label lateFeeLabel;
            System.Windows.Forms.Label damageFeeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaType));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.mediaTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTypeTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.MediaTypeTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.mediaTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mediaTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediaTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.mediaTypeTextBox = new System.Windows.Forms.TextBox();
            this.mediaDscrpTextBox = new System.Windows.Forms.TextBox();
            this.lateFeeTextBox = new System.Windows.Forms.TextBox();
            this.damageFeeTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            mediaTypeIDLabel = new System.Windows.Forms.Label();
            mediaTypeLabel = new System.Windows.Forms.Label();
            mediaDscrpLabel = new System.Windows.Forms.Label();
            lateFeeLabel = new System.Windows.Forms.Label();
            damageFeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingNavigator)).BeginInit();
            this.mediaTypeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaTypeIDLabel
            // 
            mediaTypeIDLabel.AutoSize = true;
            mediaTypeIDLabel.Location = new System.Drawing.Point(15, 44);
            mediaTypeIDLabel.Name = "mediaTypeIDLabel";
            mediaTypeIDLabel.Size = new System.Drawing.Size(80, 13);
            mediaTypeIDLabel.TabIndex = 1;
            mediaTypeIDLabel.Text = "Media Type ID:";
            // 
            // mediaTypeLabel
            // 
            mediaTypeLabel.AutoSize = true;
            mediaTypeLabel.Location = new System.Drawing.Point(15, 70);
            mediaTypeLabel.Name = "mediaTypeLabel";
            mediaTypeLabel.Size = new System.Drawing.Size(66, 13);
            mediaTypeLabel.TabIndex = 3;
            mediaTypeLabel.Text = "Media Type:";
            // 
            // mediaDscrpLabel
            // 
            mediaDscrpLabel.AutoSize = true;
            mediaDscrpLabel.Location = new System.Drawing.Point(15, 96);
            mediaDscrpLabel.Name = "mediaDscrpLabel";
            mediaDscrpLabel.Size = new System.Drawing.Size(70, 13);
            mediaDscrpLabel.TabIndex = 5;
            mediaDscrpLabel.Text = "Media Dscrp:";
            // 
            // lateFeeLabel
            // 
            lateFeeLabel.AutoSize = true;
            lateFeeLabel.Location = new System.Drawing.Point(15, 122);
            lateFeeLabel.Name = "lateFeeLabel";
            lateFeeLabel.Size = new System.Drawing.Size(52, 13);
            lateFeeLabel.TabIndex = 7;
            lateFeeLabel.Text = "Late Fee:";
            // 
            // damageFeeLabel
            // 
            damageFeeLabel.AutoSize = true;
            damageFeeLabel.Location = new System.Drawing.Point(15, 148);
            damageFeeLabel.Name = "damageFeeLabel";
            damageFeeLabel.Size = new System.Drawing.Size(71, 13);
            damageFeeLabel.TabIndex = 9;
            damageFeeLabel.Text = "Damage Fee:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaTypeBindingSource
            // 
            this.mediaTypeBindingSource.DataMember = "MediaType";
            this.mediaTypeBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // mediaTypeTableAdapter
            // 
            this.mediaTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = this.mediaTypeTableAdapter;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mediaTypeBindingNavigator
            // 
            this.mediaTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mediaTypeBindingNavigator.BindingSource = this.mediaTypeBindingSource;
            this.mediaTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediaTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mediaTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mediaTypeBindingNavigatorSaveItem});
            this.mediaTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediaTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediaTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediaTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediaTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediaTypeBindingNavigator.Name = "mediaTypeBindingNavigator";
            this.mediaTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediaTypeBindingNavigator.Size = new System.Drawing.Size(283, 25);
            this.mediaTypeBindingNavigator.TabIndex = 0;
            this.mediaTypeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mediaTypeBindingNavigatorSaveItem
            // 
            this.mediaTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediaTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaTypeBindingNavigatorSaveItem.Image")));
            this.mediaTypeBindingNavigatorSaveItem.Name = "mediaTypeBindingNavigatorSaveItem";
            this.mediaTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mediaTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.mediaTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.mediaTypeBindingNavigatorSaveItem_Click);
            // 
            // mediaTypeIDTextBox
            // 
            this.mediaTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTypeBindingSource, "MediaTypeID", true));
            this.mediaTypeIDTextBox.Location = new System.Drawing.Point(101, 41);
            this.mediaTypeIDTextBox.Name = "mediaTypeIDTextBox";
            this.mediaTypeIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.mediaTypeIDTextBox.TabIndex = 2;
            // 
            // mediaTypeTextBox
            // 
            this.mediaTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTypeBindingSource, "MediaType", true));
            this.mediaTypeTextBox.Location = new System.Drawing.Point(101, 67);
            this.mediaTypeTextBox.Name = "mediaTypeTextBox";
            this.mediaTypeTextBox.Size = new System.Drawing.Size(146, 20);
            this.mediaTypeTextBox.TabIndex = 4;
            // 
            // mediaDscrpTextBox
            // 
            this.mediaDscrpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTypeBindingSource, "MediaDscrp", true));
            this.mediaDscrpTextBox.Location = new System.Drawing.Point(101, 93);
            this.mediaDscrpTextBox.Name = "mediaDscrpTextBox";
            this.mediaDscrpTextBox.Size = new System.Drawing.Size(146, 20);
            this.mediaDscrpTextBox.TabIndex = 6;
            // 
            // lateFeeTextBox
            // 
            this.lateFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTypeBindingSource, "LateFee", true));
            this.lateFeeTextBox.Location = new System.Drawing.Point(101, 119);
            this.lateFeeTextBox.Name = "lateFeeTextBox";
            this.lateFeeTextBox.Size = new System.Drawing.Size(146, 20);
            this.lateFeeTextBox.TabIndex = 8;
            // 
            // damageFeeTextBox
            // 
            this.damageFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTypeBindingSource, "DamageFee", true));
            this.damageFeeTextBox.Location = new System.Drawing.Point(101, 145);
            this.damageFeeTextBox.Name = "damageFeeTextBox";
            this.damageFeeTextBox.Size = new System.Drawing.Size(146, 20);
            this.damageFeeTextBox.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(112, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MediaType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 206);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(mediaTypeIDLabel);
            this.Controls.Add(this.mediaTypeIDTextBox);
            this.Controls.Add(mediaTypeLabel);
            this.Controls.Add(this.mediaTypeTextBox);
            this.Controls.Add(mediaDscrpLabel);
            this.Controls.Add(this.mediaDscrpTextBox);
            this.Controls.Add(lateFeeLabel);
            this.Controls.Add(this.lateFeeTextBox);
            this.Controls.Add(damageFeeLabel);
            this.Controls.Add(this.damageFeeTextBox);
            this.Controls.Add(this.mediaTypeBindingNavigator);
            this.Name = "MediaType";
            this.Text = "MediaType";
            this.Load += new System.EventHandler(this.MediaType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingNavigator)).EndInit();
            this.mediaTypeBindingNavigator.ResumeLayout(false);
            this.mediaTypeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource mediaTypeBindingSource;
        private MediaLibraryDataSetTableAdapters.MediaTypeTableAdapter mediaTypeTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mediaTypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mediaTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mediaTypeIDTextBox;
        private System.Windows.Forms.TextBox mediaTypeTextBox;
        private System.Windows.Forms.TextBox mediaDscrpTextBox;
        private System.Windows.Forms.TextBox lateFeeTextBox;
        private System.Windows.Forms.TextBox damageFeeTextBox;
        private System.Windows.Forms.Button btnClose;
    }
}