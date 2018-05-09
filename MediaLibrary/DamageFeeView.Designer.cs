namespace MediaLibrary
{
    partial class DamageFeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamageFeeView));
            System.Windows.Forms.Label patronIDFKLabel;
            System.Windows.Forms.Label checkoutIDLabel;
            System.Windows.Forms.Label fineAmountLabel;
            System.Windows.Forms.Label paidAmountLabel;
            System.Windows.Forms.Label paidDateLabel;
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
            this.patronIDFKTextBox = new System.Windows.Forms.TextBox();
            this.checkoutIDTextBox = new System.Windows.Forms.TextBox();
            this.fineAmountTextBox = new System.Windows.Forms.TextBox();
            this.paidAmountTextBox = new System.Windows.Forms.TextBox();
            this.paidDateTextBox = new System.Windows.Forms.TextBox();
            patronIDFKLabel = new System.Windows.Forms.Label();
            checkoutIDLabel = new System.Windows.Forms.Label();
            fineAmountLabel = new System.Windows.Forms.Label();
            paidAmountLabel = new System.Windows.Forms.Label();
            paidDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingNavigator)).BeginInit();
            this.damageFeeViewBindingNavigator.SuspendLayout();
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
            this.damageFeeViewBindingNavigator.Size = new System.Drawing.Size(292, 25);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // damageFeeViewBindingNavigatorSaveItem
            // 
            this.damageFeeViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.damageFeeViewBindingNavigatorSaveItem.Enabled = false;
            this.damageFeeViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("damageFeeViewBindingNavigatorSaveItem.Image")));
            this.damageFeeViewBindingNavigatorSaveItem.Name = "damageFeeViewBindingNavigatorSaveItem";
            this.damageFeeViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.damageFeeViewBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // patronIDFKLabel
            // 
            patronIDFKLabel.AutoSize = true;
            patronIDFKLabel.Location = new System.Drawing.Point(35, 43);
            patronIDFKLabel.Name = "patronIDFKLabel";
            patronIDFKLabel.Size = new System.Drawing.Size(68, 13);
            patronIDFKLabel.TabIndex = 1;
            patronIDFKLabel.Text = "Patron IDFK:";
            // 
            // patronIDFKTextBox
            // 
            this.patronIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageFeeViewBindingSource, "PatronIDFK", true));
            this.patronIDFKTextBox.Location = new System.Drawing.Point(111, 40);
            this.patronIDFKTextBox.Name = "patronIDFKTextBox";
            this.patronIDFKTextBox.Size = new System.Drawing.Size(142, 20);
            this.patronIDFKTextBox.TabIndex = 2;
            // 
            // checkoutIDLabel
            // 
            checkoutIDLabel.AutoSize = true;
            checkoutIDLabel.Location = new System.Drawing.Point(35, 69);
            checkoutIDLabel.Name = "checkoutIDLabel";
            checkoutIDLabel.Size = new System.Drawing.Size(70, 13);
            checkoutIDLabel.TabIndex = 3;
            checkoutIDLabel.Text = "Checkout ID:";
            // 
            // checkoutIDTextBox
            // 
            this.checkoutIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageFeeViewBindingSource, "CheckoutID", true));
            this.checkoutIDTextBox.Location = new System.Drawing.Point(111, 66);
            this.checkoutIDTextBox.Name = "checkoutIDTextBox";
            this.checkoutIDTextBox.Size = new System.Drawing.Size(142, 20);
            this.checkoutIDTextBox.TabIndex = 4;
            // 
            // fineAmountLabel
            // 
            fineAmountLabel.AutoSize = true;
            fineAmountLabel.Location = new System.Drawing.Point(35, 95);
            fineAmountLabel.Name = "fineAmountLabel";
            fineAmountLabel.Size = new System.Drawing.Size(69, 13);
            fineAmountLabel.TabIndex = 5;
            fineAmountLabel.Text = "Fine Amount:";
            // 
            // fineAmountTextBox
            // 
            this.fineAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageFeeViewBindingSource, "FineAmount", true));
            this.fineAmountTextBox.Location = new System.Drawing.Point(111, 92);
            this.fineAmountTextBox.Name = "fineAmountTextBox";
            this.fineAmountTextBox.Size = new System.Drawing.Size(142, 20);
            this.fineAmountTextBox.TabIndex = 6;
            // 
            // paidAmountLabel
            // 
            paidAmountLabel.AutoSize = true;
            paidAmountLabel.Location = new System.Drawing.Point(35, 121);
            paidAmountLabel.Name = "paidAmountLabel";
            paidAmountLabel.Size = new System.Drawing.Size(70, 13);
            paidAmountLabel.TabIndex = 7;
            paidAmountLabel.Text = "Paid Amount:";
            // 
            // paidAmountTextBox
            // 
            this.paidAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageFeeViewBindingSource, "PaidAmount", true));
            this.paidAmountTextBox.Location = new System.Drawing.Point(111, 118);
            this.paidAmountTextBox.Name = "paidAmountTextBox";
            this.paidAmountTextBox.Size = new System.Drawing.Size(142, 20);
            this.paidAmountTextBox.TabIndex = 8;
            // 
            // paidDateLabel
            // 
            paidDateLabel.AutoSize = true;
            paidDateLabel.Location = new System.Drawing.Point(35, 147);
            paidDateLabel.Name = "paidDateLabel";
            paidDateLabel.Size = new System.Drawing.Size(57, 13);
            paidDateLabel.TabIndex = 9;
            paidDateLabel.Text = "Paid Date:";
            // 
            // paidDateTextBox
            // 
            this.paidDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.damageFeeViewBindingSource, "PaidDate", true));
            this.paidDateTextBox.Location = new System.Drawing.Point(111, 144);
            this.paidDateTextBox.Name = "paidDateTextBox";
            this.paidDateTextBox.Size = new System.Drawing.Size(142, 20);
            this.paidDateTextBox.TabIndex = 10;
            // 
            // DamageFeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 190);
            this.Controls.Add(patronIDFKLabel);
            this.Controls.Add(this.patronIDFKTextBox);
            this.Controls.Add(checkoutIDLabel);
            this.Controls.Add(this.checkoutIDTextBox);
            this.Controls.Add(fineAmountLabel);
            this.Controls.Add(this.fineAmountTextBox);
            this.Controls.Add(paidAmountLabel);
            this.Controls.Add(this.paidAmountTextBox);
            this.Controls.Add(paidDateLabel);
            this.Controls.Add(this.paidDateTextBox);
            this.Controls.Add(this.damageFeeViewBindingNavigator);
            this.Name = "DamageFeeView";
            this.Text = "Damage Fee View";
            this.Load += new System.EventHandler(this.DamageFeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageFeeViewBindingNavigator)).EndInit();
            this.damageFeeViewBindingNavigator.ResumeLayout(false);
            this.damageFeeViewBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox patronIDFKTextBox;
        private System.Windows.Forms.TextBox checkoutIDTextBox;
        private System.Windows.Forms.TextBox fineAmountTextBox;
        private System.Windows.Forms.TextBox paidAmountTextBox;
        private System.Windows.Forms.TextBox paidDateTextBox;
    }
}