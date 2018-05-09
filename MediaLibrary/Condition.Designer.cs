namespace MediaLibrary
{
    partial class Condition
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
            System.Windows.Forms.Label conditionIDLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label conditionDscrpLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condition));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.ConditionTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.conditionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.conditionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.conditionIDTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.conditionDscrpTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            conditionIDLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            conditionDscrpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingNavigator)).BeginInit();
            this.conditionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // conditionIDLabel
            // 
            conditionIDLabel.AutoSize = true;
            conditionIDLabel.Location = new System.Drawing.Point(34, 44);
            conditionIDLabel.Name = "conditionIDLabel";
            conditionIDLabel.Size = new System.Drawing.Size(68, 13);
            conditionIDLabel.TabIndex = 1;
            conditionIDLabel.Text = "Condition ID:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(34, 70);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(54, 13);
            conditionLabel.TabIndex = 3;
            conditionLabel.Text = "Condition:";
            // 
            // conditionDscrpLabel
            // 
            conditionDscrpLabel.AutoSize = true;
            conditionDscrpLabel.Location = new System.Drawing.Point(34, 96);
            conditionDscrpLabel.Name = "conditionDscrpLabel";
            conditionDscrpLabel.Size = new System.Drawing.Size(85, 13);
            conditionDscrpLabel.TabIndex = 5;
            conditionDscrpLabel.Text = "Condition Dscrp:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = this.conditionTableAdapter;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // conditionBindingNavigator
            // 
            this.conditionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.conditionBindingNavigator.BindingSource = this.conditionBindingSource;
            this.conditionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.conditionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.conditionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.conditionBindingNavigatorSaveItem});
            this.conditionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.conditionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.conditionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.conditionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.conditionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.conditionBindingNavigator.Name = "conditionBindingNavigator";
            this.conditionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conditionBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.conditionBindingNavigator.TabIndex = 0;
            this.conditionBindingNavigator.Text = "bindingNavigator1";
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
            // conditionBindingNavigatorSaveItem
            // 
            this.conditionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.conditionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("conditionBindingNavigatorSaveItem.Image")));
            this.conditionBindingNavigatorSaveItem.Name = "conditionBindingNavigatorSaveItem";
            this.conditionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.conditionBindingNavigatorSaveItem.Text = "Save Data";
            this.conditionBindingNavigatorSaveItem.Click += new System.EventHandler(this.conditionBindingNavigatorSaveItem_Click);
            // 
            // conditionIDTextBox
            // 
            this.conditionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "ConditionID", true));
            this.conditionIDTextBox.Location = new System.Drawing.Point(125, 41);
            this.conditionIDTextBox.Name = "conditionIDTextBox";
            this.conditionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.conditionIDTextBox.TabIndex = 2;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "Condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(125, 67);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 20);
            this.conditionTextBox.TabIndex = 4;
            // 
            // conditionDscrpTextBox
            // 
            this.conditionDscrpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "ConditionDscrp", true));
            this.conditionDscrpTextBox.Location = new System.Drawing.Point(125, 93);
            this.conditionDscrpTextBox.Name = "conditionDscrpTextBox";
            this.conditionDscrpTextBox.Size = new System.Drawing.Size(100, 20);
            this.conditionDscrpTextBox.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(102, 123);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Condition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(conditionIDLabel);
            this.Controls.Add(this.conditionIDTextBox);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(conditionDscrpLabel);
            this.Controls.Add(this.conditionDscrpTextBox);
            this.Controls.Add(this.conditionBindingNavigator);
            this.Name = "Condition";
            this.Text = "Condition";
            this.Load += new System.EventHandler(this.Condition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingNavigator)).EndInit();
            this.conditionBindingNavigator.ResumeLayout(false);
            this.conditionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private MediaLibraryDataSetTableAdapters.ConditionTableAdapter conditionTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator conditionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton conditionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox conditionIDTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox conditionDscrpTextBox;
        private System.Windows.Forms.Button btnClose;
    }
}