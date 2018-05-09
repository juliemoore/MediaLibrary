namespace MediaLibrary
{
    partial class Checkout
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
            System.Windows.Forms.Label checkoutIDLabel;
            System.Windows.Forms.Label mediaItemIDFKLabel;
            System.Windows.Forms.Label patronIDFKLabel;
            System.Windows.Forms.Label outDateLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label outConditionIDFKLabel;
            System.Windows.Forms.Label returnConditionIDFKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.checkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkoutTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.CheckoutTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.checkoutBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.checkoutBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.checkoutIDTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mediaItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaItemTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.MediaItemTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.conditionTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.ConditionTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.outDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            checkoutIDLabel = new System.Windows.Forms.Label();
            mediaItemIDFKLabel = new System.Windows.Forms.Label();
            patronIDFKLabel = new System.Windows.Forms.Label();
            outDateLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            outConditionIDFKLabel = new System.Windows.Forms.Label();
            returnConditionIDFKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingNavigator)).BeginInit();
            this.checkoutBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutIDLabel
            // 
            checkoutIDLabel.AutoSize = true;
            checkoutIDLabel.Location = new System.Drawing.Point(39, 42);
            checkoutIDLabel.Name = "checkoutIDLabel";
            checkoutIDLabel.Size = new System.Drawing.Size(70, 13);
            checkoutIDLabel.TabIndex = 1;
            checkoutIDLabel.Text = "Checkout ID:";
            // 
            // mediaItemIDFKLabel
            // 
            mediaItemIDFKLabel.AutoSize = true;
            mediaItemIDFKLabel.Location = new System.Drawing.Point(39, 68);
            mediaItemIDFKLabel.Name = "mediaItemIDFKLabel";
            mediaItemIDFKLabel.Size = new System.Drawing.Size(76, 13);
            mediaItemIDFKLabel.TabIndex = 3;
            mediaItemIDFKLabel.Text = "Media Item ID:";
            // 
            // patronIDFKLabel
            // 
            patronIDFKLabel.AutoSize = true;
            patronIDFKLabel.Location = new System.Drawing.Point(39, 94);
            patronIDFKLabel.Name = "patronIDFKLabel";
            patronIDFKLabel.Size = new System.Drawing.Size(55, 13);
            patronIDFKLabel.TabIndex = 5;
            patronIDFKLabel.Text = "Patron ID:";
            // 
            // outDateLabel
            // 
            outDateLabel.AutoSize = true;
            outDateLabel.Location = new System.Drawing.Point(39, 121);
            outDateLabel.Name = "outDateLabel";
            outDateLabel.Size = new System.Drawing.Size(53, 13);
            outDateLabel.TabIndex = 7;
            outDateLabel.Text = "Out Date:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(39, 147);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 9;
            dueDateLabel.Text = "Due Date:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(39, 173);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(68, 13);
            returnDateLabel.TabIndex = 11;
            returnDateLabel.Text = "Return Date:";
            // 
            // outConditionIDFKLabel
            // 
            outConditionIDFKLabel.AutoSize = true;
            outConditionIDFKLabel.Location = new System.Drawing.Point(39, 198);
            outConditionIDFKLabel.Name = "outConditionIDFKLabel";
            outConditionIDFKLabel.Size = new System.Drawing.Size(88, 13);
            outConditionIDFKLabel.TabIndex = 13;
            outConditionIDFKLabel.Text = "Out Condition ID:";
            // 
            // returnConditionIDFKLabel
            // 
            returnConditionIDFKLabel.AutoSize = true;
            returnConditionIDFKLabel.Location = new System.Drawing.Point(39, 224);
            returnConditionIDFKLabel.Name = "returnConditionIDFKLabel";
            returnConditionIDFKLabel.Size = new System.Drawing.Size(103, 13);
            returnConditionIDFKLabel.TabIndex = 15;
            returnConditionIDFKLabel.Text = "Return Condition ID:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkoutBindingSource
            // 
            this.checkoutBindingSource.DataMember = "Checkout";
            this.checkoutBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // checkoutTableAdapter
            // 
            this.checkoutTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = this.checkoutTableAdapter;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // checkoutBindingNavigator
            // 
            this.checkoutBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.checkoutBindingNavigator.BindingSource = this.checkoutBindingSource;
            this.checkoutBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.checkoutBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.checkoutBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.checkoutBindingNavigatorSaveItem});
            this.checkoutBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.checkoutBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.checkoutBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.checkoutBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.checkoutBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.checkoutBindingNavigator.Name = "checkoutBindingNavigator";
            this.checkoutBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.checkoutBindingNavigator.Size = new System.Drawing.Size(408, 25);
            this.checkoutBindingNavigator.TabIndex = 0;
            this.checkoutBindingNavigator.Text = "bindingNavigator1";
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
            // checkoutBindingNavigatorSaveItem
            // 
            this.checkoutBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.checkoutBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("checkoutBindingNavigatorSaveItem.Image")));
            this.checkoutBindingNavigatorSaveItem.Name = "checkoutBindingNavigatorSaveItem";
            this.checkoutBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.checkoutBindingNavigatorSaveItem.Text = "Save Data";
            this.checkoutBindingNavigatorSaveItem.Click += new System.EventHandler(this.checkoutBindingNavigatorSaveItem_Click);
            // 
            // checkoutIDTextBox
            // 
            this.checkoutIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkoutBindingSource, "CheckoutID", true));
            this.checkoutIDTextBox.Location = new System.Drawing.Point(161, 39);
            this.checkoutIDTextBox.Name = "checkoutIDTextBox";
            this.checkoutIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.checkoutIDTextBox.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.checkoutBindingSource, "MediaItemIDFK", true));
            this.comboBox1.DataSource = this.mediaItemBindingSource;
            this.comboBox1.DisplayMember = "MediaItemID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "MediaItemID";
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
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.checkoutBindingSource, "PatronIDFK", true));
            this.comboBox2.DataSource = this.patronsBindingSource;
            this.comboBox2.DisplayMember = "PatronID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "PatronID";
            // 
            // patronsBindingSource
            // 
            this.patronsBindingSource.DataMember = "Patrons";
            this.patronsBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // patronsTableAdapter
            // 
            this.patronsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.checkoutBindingSource, "OutConditionIDFK", true));
            this.comboBox3.DataSource = this.conditionBindingSource;
            this.comboBox3.DisplayMember = "ConditionDscrp";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(161, 194);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "ConditionID";
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataMember = "Condition";
            this.conditionBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.checkoutBindingSource, "ReturnConditionIDFK", true));
            this.comboBox4.DataSource = this.conditionBindingSource;
            this.comboBox4.DisplayMember = "ConditionDscrp";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(161, 221);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 21);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "ConditionID";
            // 
            // conditionTableAdapter
            // 
            this.conditionTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkoutBindingSource, "ReturnDate", true));
            this.textBox2.Location = new System.Drawing.Point(161, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 23;
            // 
            // outDateDateTimePicker
            // 
            this.outDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkoutBindingSource, "OutDate", true));
            this.outDateDateTimePicker.Location = new System.Drawing.Point(161, 117);
            this.outDateDateTimePicker.Name = "outDateDateTimePicker";
            this.outDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.outDateDateTimePicker.TabIndex = 8;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkoutBindingSource, "DueDate", true));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(161, 143);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDateTimePicker.TabIndex = 10;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 308);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(checkoutIDLabel);
            this.Controls.Add(this.checkoutIDTextBox);
            this.Controls.Add(mediaItemIDFKLabel);
            this.Controls.Add(patronIDFKLabel);
            this.Controls.Add(outDateLabel);
            this.Controls.Add(this.outDateDateTimePicker);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(returnDateLabel);
            this.Controls.Add(outConditionIDFKLabel);
            this.Controls.Add(returnConditionIDFKLabel);
            this.Controls.Add(this.checkoutBindingNavigator);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingNavigator)).EndInit();
            this.checkoutBindingNavigator.ResumeLayout(false);
            this.checkoutBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private MediaLibraryDataSetTableAdapters.CheckoutTableAdapter checkoutTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator checkoutBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton checkoutBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox checkoutIDTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mediaItemBindingSource;
        private MediaLibraryDataSetTableAdapters.MediaItemTableAdapter mediaItemTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private MediaLibraryDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private MediaLibraryDataSetTableAdapters.ConditionTableAdapter conditionTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker outDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
    }
}