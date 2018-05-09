namespace MediaLibrary
{
    partial class Fines
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
            System.Windows.Forms.Label fineIDLabel;
            System.Windows.Forms.Label patronIDFKLabel;
            System.Windows.Forms.Label checkoutIDFKLabel;
            System.Windows.Forms.Label fineAmountLabel;
            System.Windows.Forms.Label paidAmountLabel;
            System.Windows.Forms.Label paidDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fines));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finesTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.FinesTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.finesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.finesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fineIDTextBox = new System.Windows.Forms.TextBox();
            this.patronIDFKTextBox = new System.Windows.Forms.TextBox();
            this.checkoutIDFKTextBox = new System.Windows.Forms.TextBox();
            this.fineAmountTextBox = new System.Windows.Forms.TextBox();
            this.paidAmountTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            fineIDLabel = new System.Windows.Forms.Label();
            patronIDFKLabel = new System.Windows.Forms.Label();
            checkoutIDFKLabel = new System.Windows.Forms.Label();
            fineAmountLabel = new System.Windows.Forms.Label();
            paidAmountLabel = new System.Windows.Forms.Label();
            paidDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingNavigator)).BeginInit();
            this.finesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fineIDLabel
            // 
            fineIDLabel.AutoSize = true;
            fineIDLabel.Location = new System.Drawing.Point(29, 43);
            fineIDLabel.Name = "fineIDLabel";
            fineIDLabel.Size = new System.Drawing.Size(44, 13);
            fineIDLabel.TabIndex = 1;
            fineIDLabel.Text = "Fine ID:";
            // 
            // patronIDFKLabel
            // 
            patronIDFKLabel.AutoSize = true;
            patronIDFKLabel.Location = new System.Drawing.Point(29, 69);
            patronIDFKLabel.Name = "patronIDFKLabel";
            patronIDFKLabel.Size = new System.Drawing.Size(68, 13);
            patronIDFKLabel.TabIndex = 3;
            patronIDFKLabel.Text = "Patron IDFK:";
            // 
            // checkoutIDFKLabel
            // 
            checkoutIDFKLabel.AutoSize = true;
            checkoutIDFKLabel.Location = new System.Drawing.Point(29, 95);
            checkoutIDFKLabel.Name = "checkoutIDFKLabel";
            checkoutIDFKLabel.Size = new System.Drawing.Size(83, 13);
            checkoutIDFKLabel.TabIndex = 5;
            checkoutIDFKLabel.Text = "Checkout IDFK:";
            // 
            // fineAmountLabel
            // 
            fineAmountLabel.AutoSize = true;
            fineAmountLabel.Location = new System.Drawing.Point(29, 121);
            fineAmountLabel.Name = "fineAmountLabel";
            fineAmountLabel.Size = new System.Drawing.Size(69, 13);
            fineAmountLabel.TabIndex = 7;
            fineAmountLabel.Text = "Fine Amount:";
            // 
            // paidAmountLabel
            // 
            paidAmountLabel.AutoSize = true;
            paidAmountLabel.Location = new System.Drawing.Point(29, 147);
            paidAmountLabel.Name = "paidAmountLabel";
            paidAmountLabel.Size = new System.Drawing.Size(70, 13);
            paidAmountLabel.TabIndex = 9;
            paidAmountLabel.Text = "Paid Amount:";
            // 
            // paidDateLabel
            // 
            paidDateLabel.AutoSize = true;
            paidDateLabel.Location = new System.Drawing.Point(29, 174);
            paidDateLabel.Name = "paidDateLabel";
            paidDateLabel.Size = new System.Drawing.Size(57, 13);
            paidDateLabel.TabIndex = 11;
            paidDateLabel.Text = "Paid Date:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finesBindingSource
            // 
            this.finesBindingSource.DataMember = "Fines";
            this.finesBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // finesTableAdapter
            // 
            this.finesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.FinesTableAdapter = this.finesTableAdapter;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // finesBindingNavigator
            // 
            this.finesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.finesBindingNavigator.BindingSource = this.finesBindingSource;
            this.finesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.finesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.finesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.finesBindingNavigatorSaveItem});
            this.finesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.finesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.finesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.finesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.finesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.finesBindingNavigator.Name = "finesBindingNavigator";
            this.finesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.finesBindingNavigator.Size = new System.Drawing.Size(360, 25);
            this.finesBindingNavigator.TabIndex = 0;
            this.finesBindingNavigator.Text = "bindingNavigator1";
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
            // finesBindingNavigatorSaveItem
            // 
            this.finesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.finesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("finesBindingNavigatorSaveItem.Image")));
            this.finesBindingNavigatorSaveItem.Name = "finesBindingNavigatorSaveItem";
            this.finesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.finesBindingNavigatorSaveItem.Text = "Save Data";
            this.finesBindingNavigatorSaveItem.Click += new System.EventHandler(this.finesBindingNavigatorSaveItem_Click);
            // 
            // fineIDTextBox
            // 
            this.fineIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.finesBindingSource, "FineID", true));
            this.fineIDTextBox.Location = new System.Drawing.Point(118, 40);
            this.fineIDTextBox.Name = "fineIDTextBox";
            this.fineIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.fineIDTextBox.TabIndex = 2;
            // 
            // patronIDFKTextBox
            // 
            this.patronIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.finesBindingSource, "PatronIDFK", true));
            this.patronIDFKTextBox.Location = new System.Drawing.Point(118, 66);
            this.patronIDFKTextBox.Name = "patronIDFKTextBox";
            this.patronIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronIDFKTextBox.TabIndex = 4;
            // 
            // checkoutIDFKTextBox
            // 
            this.checkoutIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.finesBindingSource, "CheckoutIDFK", true));
            this.checkoutIDFKTextBox.Location = new System.Drawing.Point(118, 92);
            this.checkoutIDFKTextBox.Name = "checkoutIDFKTextBox";
            this.checkoutIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.checkoutIDFKTextBox.TabIndex = 6;
            // 
            // fineAmountTextBox
            // 
            this.fineAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.finesBindingSource, "FineAmount", true));
            this.fineAmountTextBox.Location = new System.Drawing.Point(118, 118);
            this.fineAmountTextBox.Name = "fineAmountTextBox";
            this.fineAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.fineAmountTextBox.TabIndex = 8;
            // 
            // paidAmountTextBox
            // 
            this.paidAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.finesBindingSource, "PaidAmount", true));
            this.paidAmountTextBox.Location = new System.Drawing.Point(118, 144);
            this.paidAmountTextBox.Name = "paidAmountTextBox";
            this.paidAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.paidAmountTextBox.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(149, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.finesBindingSource, "PaidDate", true));
            this.textBox1.Location = new System.Drawing.Point(118, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 232);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(fineIDLabel);
            this.Controls.Add(this.fineIDTextBox);
            this.Controls.Add(patronIDFKLabel);
            this.Controls.Add(this.patronIDFKTextBox);
            this.Controls.Add(checkoutIDFKLabel);
            this.Controls.Add(this.checkoutIDFKTextBox);
            this.Controls.Add(fineAmountLabel);
            this.Controls.Add(this.fineAmountTextBox);
            this.Controls.Add(paidAmountLabel);
            this.Controls.Add(this.paidAmountTextBox);
            this.Controls.Add(paidDateLabel);
            this.Controls.Add(this.finesBindingNavigator);
            this.Name = "Fines";
            this.Text = "Fines";
            this.Load += new System.EventHandler(this.Fines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingNavigator)).EndInit();
            this.finesBindingNavigator.ResumeLayout(false);
            this.finesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource finesBindingSource;
        private MediaLibraryDataSetTableAdapters.FinesTableAdapter finesTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator finesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton finesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fineIDTextBox;
        private System.Windows.Forms.TextBox patronIDFKTextBox;
        private System.Windows.Forms.TextBox checkoutIDFKTextBox;
        private System.Windows.Forms.TextBox fineAmountTextBox;
        private System.Windows.Forms.TextBox paidAmountTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
    }
}