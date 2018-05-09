namespace MediaLibrary
{
    partial class MediaItem
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
            System.Windows.Forms.Label mediaItemIDLabel;
            System.Windows.Forms.Label mediaTitleIDFKLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label circulationStatusLabel;
            System.Windows.Forms.Label conditionIDFKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaItem));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.mediaItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaItemTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.MediaItemTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.mediaItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mediaItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediaItemIDTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.circulationStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mediaTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTitleTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.MediaTitleTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.ConditionTableAdapter();
            mediaItemIDLabel = new System.Windows.Forms.Label();
            mediaTitleIDFKLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            circulationStatusLabel = new System.Windows.Forms.Label();
            conditionIDFKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemBindingNavigator)).BeginInit();
            this.mediaItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaItemIDLabel
            // 
            mediaItemIDLabel.AutoSize = true;
            mediaItemIDLabel.Location = new System.Drawing.Point(23, 44);
            mediaItemIDLabel.Name = "mediaItemIDLabel";
            mediaItemIDLabel.Size = new System.Drawing.Size(76, 13);
            mediaItemIDLabel.TabIndex = 1;
            mediaItemIDLabel.Text = "Media Item ID:";
            // 
            // mediaTitleIDFKLabel
            // 
            mediaTitleIDFKLabel.AutoSize = true;
            mediaTitleIDFKLabel.Location = new System.Drawing.Point(23, 70);
            mediaTitleIDFKLabel.Name = "mediaTitleIDFKLabel";
            mediaTitleIDFKLabel.Size = new System.Drawing.Size(62, 13);
            mediaTitleIDFKLabel.TabIndex = 3;
            mediaTitleIDFKLabel.Text = "Media Title:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(23, 97);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 5;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // circulationStatusLabel
            // 
            circulationStatusLabel.AutoSize = true;
            circulationStatusLabel.Location = new System.Drawing.Point(23, 124);
            circulationStatusLabel.Name = "circulationStatusLabel";
            circulationStatusLabel.Size = new System.Drawing.Size(92, 13);
            circulationStatusLabel.TabIndex = 7;
            circulationStatusLabel.Text = "Circulation Status:";
            // 
            // conditionIDFKLabel
            // 
            conditionIDFKLabel.AutoSize = true;
            conditionIDFKLabel.Location = new System.Drawing.Point(23, 152);
            conditionIDFKLabel.Name = "conditionIDFKLabel";
            conditionIDFKLabel.Size = new System.Drawing.Size(54, 13);
            conditionIDFKLabel.TabIndex = 9;
            conditionIDFKLabel.Text = "Condition:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaItemBindingSource
            // 
            this.mediaItemBindingSource.DataMember = "MediaItem";
            this.mediaItemBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // mediaItemTableAdapter
            // 
            this.mediaItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = this.mediaItemTableAdapter;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mediaItemBindingNavigator
            // 
            this.mediaItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mediaItemBindingNavigator.BindingSource = this.mediaItemBindingSource;
            this.mediaItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediaItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mediaItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mediaItemBindingNavigatorSaveItem});
            this.mediaItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediaItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediaItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediaItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediaItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediaItemBindingNavigator.Name = "mediaItemBindingNavigator";
            this.mediaItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediaItemBindingNavigator.Size = new System.Drawing.Size(359, 25);
            this.mediaItemBindingNavigator.TabIndex = 0;
            this.mediaItemBindingNavigator.Text = "bindingNavigator1";
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
            // mediaItemBindingNavigatorSaveItem
            // 
            this.mediaItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediaItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaItemBindingNavigatorSaveItem.Image")));
            this.mediaItemBindingNavigatorSaveItem.Name = "mediaItemBindingNavigatorSaveItem";
            this.mediaItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mediaItemBindingNavigatorSaveItem.Text = "Save Data";
            this.mediaItemBindingNavigatorSaveItem.Click += new System.EventHandler(this.mediaItemBindingNavigatorSaveItem_Click);
            // 
            // mediaItemIDTextBox
            // 
            this.mediaItemIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediaItemBindingSource, "MediaItemID", true));
            this.mediaItemIDTextBox.Location = new System.Drawing.Point(121, 41);
            this.mediaItemIDTextBox.Name = "mediaItemIDTextBox";
            this.mediaItemIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.mediaItemIDTextBox.TabIndex = 2;
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mediaItemBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(121, 93);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 6;
            // 
            // circulationStatusCheckBox
            // 
            this.circulationStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediaItemBindingSource, "CirculationStatus", true));
            this.circulationStatusCheckBox.Location = new System.Drawing.Point(121, 119);
            this.circulationStatusCheckBox.Name = "circulationStatusCheckBox";
            this.circulationStatusCheckBox.Size = new System.Drawing.Size(200, 24);
            this.circulationStatusCheckBox.TabIndex = 8;
            this.circulationStatusCheckBox.Text = "In Circulation";
            this.circulationStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(139, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mediaItemBindingSource, "MediaTitleIDFK", true));
            this.comboBox1.DataSource = this.mediaTitleBindingSource;
            this.comboBox1.DisplayMember = "MediaTitle";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "MediaTitleID";
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
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mediaItemBindingSource, "ConditionIDFK", true));
            this.comboBox2.DataSource = this.conditionBindingSource;
            this.comboBox2.DisplayMember = "ConditionDscrp";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "ConditionID";
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataMember = "Condition";
            this.conditionBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // conditionTableAdapter
            // 
            this.conditionTableAdapter.ClearBeforeFill = true;
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 212);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(mediaItemIDLabel);
            this.Controls.Add(this.mediaItemIDTextBox);
            this.Controls.Add(mediaTitleIDFKLabel);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(circulationStatusLabel);
            this.Controls.Add(this.circulationStatusCheckBox);
            this.Controls.Add(conditionIDFKLabel);
            this.Controls.Add(this.mediaItemBindingNavigator);
            this.Name = "MediaItem";
            this.Text = "Media Item";
            this.Load += new System.EventHandler(this.MediaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemBindingNavigator)).EndInit();
            this.mediaItemBindingNavigator.ResumeLayout(false);
            this.mediaItemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource mediaItemBindingSource;
        private MediaLibraryDataSetTableAdapters.MediaItemTableAdapter mediaItemTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mediaItemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mediaItemBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mediaItemIDTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.CheckBox circulationStatusCheckBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mediaTitleBindingSource;
        private MediaLibraryDataSetTableAdapters.MediaTitleTableAdapter mediaTitleTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private MediaLibraryDataSetTableAdapters.ConditionTableAdapter conditionTableAdapter;
    }
}