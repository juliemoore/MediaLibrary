namespace MediaLibrary
{
    partial class MediaTitle
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
            System.Windows.Forms.Label mediaTitleIDLabel;
            System.Windows.Forms.Label mediaTypeIDFKLabel;
            System.Windows.Forms.Label mediaTitleLabel;
            System.Windows.Forms.Label mediaTitleDscrpLabel;
            System.Windows.Forms.Label purchaseCostLabel;
            System.Windows.Forms.Label authorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaTitle));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.mediaTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTitleTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.MediaTitleTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.mediaTitleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mediaTitleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediaTitleIDTextBox = new System.Windows.Forms.TextBox();
            this.mediaTitleTextBox = new System.Windows.Forms.TextBox();
            this.purchaseCostTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboMediaTypeID = new System.Windows.Forms.ComboBox();
            this.mediaTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTypeTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.MediaTypeTableAdapter();
            this.fKMediaTitleMediaTypeIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKMediaTitleMediaTypeIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            mediaTitleIDLabel = new System.Windows.Forms.Label();
            mediaTypeIDFKLabel = new System.Windows.Forms.Label();
            mediaTitleLabel = new System.Windows.Forms.Label();
            mediaTitleDscrpLabel = new System.Windows.Forms.Label();
            purchaseCostLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTitleBindingNavigator)).BeginInit();
            this.mediaTitleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMediaTitleMediaTypeIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMediaTitleMediaTypeIDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaTitleIDLabel
            // 
            mediaTitleIDLabel.AutoSize = true;
            mediaTitleIDLabel.Location = new System.Drawing.Point(12, 41);
            mediaTitleIDLabel.Name = "mediaTitleIDLabel";
            mediaTitleIDLabel.Size = new System.Drawing.Size(76, 13);
            mediaTitleIDLabel.TabIndex = 1;
            mediaTitleIDLabel.Text = "Media Title ID:";
            // 
            // mediaTypeIDFKLabel
            // 
            mediaTypeIDFKLabel.AutoSize = true;
            mediaTypeIDFKLabel.Location = new System.Drawing.Point(12, 67);
            mediaTypeIDFKLabel.Name = "mediaTypeIDFKLabel";
            mediaTypeIDFKLabel.Size = new System.Drawing.Size(66, 13);
            mediaTypeIDFKLabel.TabIndex = 3;
            mediaTypeIDFKLabel.Text = "Media Type:";
            // 
            // mediaTitleLabel
            // 
            mediaTitleLabel.AutoSize = true;
            mediaTitleLabel.Location = new System.Drawing.Point(12, 93);
            mediaTitleLabel.Name = "mediaTitleLabel";
            mediaTitleLabel.Size = new System.Drawing.Size(62, 13);
            mediaTitleLabel.TabIndex = 5;
            mediaTitleLabel.Text = "Media Title:";
            // 
            // mediaTitleDscrpLabel
            // 
            mediaTitleDscrpLabel.AutoSize = true;
            mediaTitleDscrpLabel.Location = new System.Drawing.Point(12, 119);
            mediaTitleDscrpLabel.Name = "mediaTitleDscrpLabel";
            mediaTitleDscrpLabel.Size = new System.Drawing.Size(93, 13);
            mediaTitleDscrpLabel.TabIndex = 7;
            mediaTitleDscrpLabel.Text = "Media Title Dscrp:";
            // 
            // purchaseCostLabel
            // 
            purchaseCostLabel.AutoSize = true;
            purchaseCostLabel.Location = new System.Drawing.Point(12, 253);
            purchaseCostLabel.Name = "purchaseCostLabel";
            purchaseCostLabel.Size = new System.Drawing.Size(79, 13);
            purchaseCostLabel.TabIndex = 9;
            purchaseCostLabel.Text = "Purchase Cost:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(12, 279);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(41, 13);
            authorLabel.TabIndex = 11;
            authorLabel.Text = "Author:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaTitleBindingSource
            // 
            this.mediaTitleBindingSource.DataMember = "MediaTitle";
            this.mediaTitleBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // mediaTitleTableAdapter
            // 
            this.mediaTitleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = this.mediaTitleTableAdapter;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mediaTitleBindingNavigator
            // 
            this.mediaTitleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mediaTitleBindingNavigator.BindingSource = this.mediaTitleBindingSource;
            this.mediaTitleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediaTitleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mediaTitleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mediaTitleBindingNavigatorSaveItem});
            this.mediaTitleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediaTitleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediaTitleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediaTitleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediaTitleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediaTitleBindingNavigator.Name = "mediaTitleBindingNavigator";
            this.mediaTitleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediaTitleBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.mediaTitleBindingNavigator.TabIndex = 0;
            this.mediaTitleBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            // mediaTitleBindingNavigatorSaveItem
            // 
            this.mediaTitleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediaTitleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaTitleBindingNavigatorSaveItem.Image")));
            this.mediaTitleBindingNavigatorSaveItem.Name = "mediaTitleBindingNavigatorSaveItem";
            this.mediaTitleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mediaTitleBindingNavigatorSaveItem.Text = "Save Data";
            this.mediaTitleBindingNavigatorSaveItem.Click += new System.EventHandler(this.mediaTitleBindingNavigatorSaveItem_Click);
            // 
            // mediaTitleIDTextBox
            // 
            this.mediaTitleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTitleBindingSource, "MediaTitleID", true));
            this.mediaTitleIDTextBox.Location = new System.Drawing.Point(111, 38);
            this.mediaTitleIDTextBox.Name = "mediaTitleIDTextBox";
            this.mediaTitleIDTextBox.Size = new System.Drawing.Size(143, 20);
            this.mediaTitleIDTextBox.TabIndex = 2;
            // 
            // mediaTitleTextBox
            // 
            this.mediaTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTitleBindingSource, "MediaTitle", true));
            this.mediaTitleTextBox.Location = new System.Drawing.Point(111, 90);
            this.mediaTitleTextBox.Name = "mediaTitleTextBox";
            this.mediaTitleTextBox.Size = new System.Drawing.Size(143, 20);
            this.mediaTitleTextBox.TabIndex = 6;
            // 
            // purchaseCostTextBox
            // 
            this.purchaseCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTitleBindingSource, "PurchaseCost", true));
            this.purchaseCostTextBox.Location = new System.Drawing.Point(111, 250);
            this.purchaseCostTextBox.Name = "purchaseCostTextBox";
            this.purchaseCostTextBox.Size = new System.Drawing.Size(143, 20);
            this.purchaseCostTextBox.TabIndex = 10;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTitleBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(111, 276);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(143, 20);
            this.authorTextBox.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(111, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboMediaTypeID
            // 
            this.comboMediaTypeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mediaTitleBindingSource, "MediaTypeIDFK", true));
            this.comboMediaTypeID.DataSource = this.mediaTypeBindingSource3;
            this.comboMediaTypeID.DisplayMember = "MediaType";
            this.comboMediaTypeID.FormattingEnabled = true;
            this.comboMediaTypeID.Location = new System.Drawing.Point(111, 63);
            this.comboMediaTypeID.Name = "comboMediaTypeID";
            this.comboMediaTypeID.Size = new System.Drawing.Size(143, 21);
            this.comboMediaTypeID.TabIndex = 14;
            this.comboMediaTypeID.ValueMember = "MediaTypeID";
            // 
            // mediaTypeBindingSource3
            // 
            this.mediaTypeBindingSource3.DataMember = "MediaType";
            this.mediaTypeBindingSource3.DataSource = this.mediaLibraryDataSet;
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
            // fKMediaTitleMediaTypeIDBindingSource
            // 
            this.fKMediaTitleMediaTypeIDBindingSource.DataMember = "FK__MediaTitle__MediaTypeID";
            this.fKMediaTitleMediaTypeIDBindingSource.DataSource = this.mediaTypeBindingSource;
            // 
            // fKMediaTitleMediaTypeIDBindingSource1
            // 
            this.fKMediaTitleMediaTypeIDBindingSource1.DataMember = "FK__MediaTitle__MediaTypeID";
            this.fKMediaTitleMediaTypeIDBindingSource1.DataSource = this.mediaTypeBindingSource;
            // 
            // mediaTypeBindingSource1
            // 
            this.mediaTypeBindingSource1.DataMember = "MediaType";
            this.mediaTypeBindingSource1.DataSource = this.mediaLibraryDataSet;
            // 
            // mediaTypeBindingSource2
            // 
            this.mediaTypeBindingSource2.DataMember = "MediaType";
            this.mediaTypeBindingSource2.DataSource = this.mediaLibraryDataSet;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaTitleBindingSource, "MediaTitleDscrp", true));
            this.richTextBox1.Location = new System.Drawing.Point(111, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(143, 125);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // MediaTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboMediaTypeID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(mediaTitleIDLabel);
            this.Controls.Add(this.mediaTitleIDTextBox);
            this.Controls.Add(mediaTypeIDFKLabel);
            this.Controls.Add(mediaTitleLabel);
            this.Controls.Add(this.mediaTitleTextBox);
            this.Controls.Add(mediaTitleDscrpLabel);
            this.Controls.Add(purchaseCostLabel);
            this.Controls.Add(this.purchaseCostTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.mediaTitleBindingNavigator);
            this.Name = "MediaTitle";
            this.Text = "MediaTitle";
            this.Load += new System.EventHandler(this.MediaTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTitleBindingNavigator)).EndInit();
            this.mediaTitleBindingNavigator.ResumeLayout(false);
            this.mediaTitleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMediaTitleMediaTypeIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMediaTitleMediaTypeIDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource mediaTitleBindingSource;
        private MediaLibraryDataSetTableAdapters.MediaTitleTableAdapter mediaTitleTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mediaTitleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mediaTitleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mediaTitleIDTextBox;
        private System.Windows.Forms.TextBox mediaTitleTextBox;
        private System.Windows.Forms.TextBox purchaseCostTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboMediaTypeID;
        private System.Windows.Forms.BindingSource mediaTypeBindingSource;
        private MediaLibraryDataSetTableAdapters.MediaTypeTableAdapter mediaTypeTableAdapter;
        private System.Windows.Forms.BindingSource fKMediaTitleMediaTypeIDBindingSource;
        private System.Windows.Forms.BindingSource fKMediaTitleMediaTypeIDBindingSource1;
        private System.Windows.Forms.BindingSource mediaTypeBindingSource1;
        private System.Windows.Forms.BindingSource mediaTypeBindingSource2;
        private System.Windows.Forms.BindingSource mediaTypeBindingSource3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}