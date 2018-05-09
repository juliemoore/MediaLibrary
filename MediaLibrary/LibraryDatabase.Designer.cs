namespace MediaLibrary
{
    partial class LibraryDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryDatabase));
            this.btnOutstandingFines = new System.Windows.Forms.Button();
            this.btnOutstandingItems = new System.Windows.Forms.Button();
            this.btnConditionFines = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.patronCheckoutsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patronCheckoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
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
            this.patronCheckoutsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnMediaType = new System.Windows.Forms.Button();
            this.btnMediaTitle = new System.Windows.Forms.Button();
            this.btnMediaItem = new System.Windows.Forms.Button();
            this.btnCondition = new System.Windows.Forms.Button();
            this.btnPatrons = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.bntFines = new System.Windows.Forms.Button();
            this.patronsDataGridView = new System.Windows.Forms.DataGridView();
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
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.btnCheckOutHist = new System.Windows.Forms.Button();
            this.patronCheckoutsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.patronsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingNavigator)).BeginInit();
            this.patronCheckoutsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOutstandingFines
            // 
            this.btnOutstandingFines.Location = new System.Drawing.Point(578, 290);
            this.btnOutstandingFines.Name = "btnOutstandingFines";
            this.btnOutstandingFines.Size = new System.Drawing.Size(155, 23);
            this.btnOutstandingFines.TabIndex = 0;
            this.btnOutstandingFines.Text = "Outstanding Fines";
            this.btnOutstandingFines.UseVisualStyleBackColor = true;
            this.btnOutstandingFines.Click += new System.EventHandler(this.btnOutstandingFines_Click);
            // 
            // btnOutstandingItems
            // 
            this.btnOutstandingItems.Location = new System.Drawing.Point(578, 348);
            this.btnOutstandingItems.Name = "btnOutstandingItems";
            this.btnOutstandingItems.Size = new System.Drawing.Size(155, 23);
            this.btnOutstandingItems.TabIndex = 1;
            this.btnOutstandingItems.Text = "Outstanding Items";
            this.btnOutstandingItems.UseVisualStyleBackColor = true;
            this.btnOutstandingItems.Click += new System.EventHandler(this.btnOutstandingItems_Click);
            // 
            // btnConditionFines
            // 
            this.btnConditionFines.Location = new System.Drawing.Point(578, 319);
            this.btnConditionFines.Name = "btnConditionFines";
            this.btnConditionFines.Size = new System.Drawing.Size(155, 23);
            this.btnConditionFines.TabIndex = 2;
            this.btnConditionFines.Text = "Condition and Fines";
            this.btnConditionFines.UseVisualStyleBackColor = true;
            this.btnConditionFines.Click += new System.EventHandler(this.btnConditionFines_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(578, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(79, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(19, 65);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(194, 24);
            this.searchTextBox.TabIndex = 0;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(578, 377);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(155, 23);
            this.btnShowDetails.TabIndex = 5;
            this.btnShowDetails.Text = "Checkout Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // patronCheckoutsBindingNavigator
            // 
            this.patronCheckoutsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patronCheckoutsBindingNavigator.BindingSource = this.patronCheckoutsBindingSource;
            this.patronCheckoutsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patronCheckoutsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patronCheckoutsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patronCheckoutsBindingNavigatorSaveItem});
            this.patronCheckoutsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patronCheckoutsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patronCheckoutsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patronCheckoutsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patronCheckoutsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patronCheckoutsBindingNavigator.Name = "patronCheckoutsBindingNavigator";
            this.patronCheckoutsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patronCheckoutsBindingNavigator.Size = new System.Drawing.Size(745, 25);
            this.patronCheckoutsBindingNavigator.TabIndex = 6;
            this.patronCheckoutsBindingNavigator.Text = "bindingNavigator1";
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
            // patronCheckoutsBindingSource
            // 
            this.patronCheckoutsBindingSource.DataMember = "PatronCheckouts";
            this.patronCheckoutsBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // patronCheckoutsBindingNavigatorSaveItem
            // 
            this.patronCheckoutsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patronCheckoutsBindingNavigatorSaveItem.Enabled = false;
            this.patronCheckoutsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patronCheckoutsBindingNavigatorSaveItem.Image")));
            this.patronCheckoutsBindingNavigatorSaveItem.Name = "patronCheckoutsBindingNavigatorSaveItem";
            this.patronCheckoutsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patronCheckoutsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // btnMediaType
            // 
            this.btnMediaType.Location = new System.Drawing.Point(578, 52);
            this.btnMediaType.Name = "btnMediaType";
            this.btnMediaType.Size = new System.Drawing.Size(155, 23);
            this.btnMediaType.TabIndex = 7;
            this.btnMediaType.Text = "Media Type";
            this.btnMediaType.UseVisualStyleBackColor = true;
            this.btnMediaType.Click += new System.EventHandler(this.btnMediaType_Click);
            // 
            // btnMediaTitle
            // 
            this.btnMediaTitle.Location = new System.Drawing.Point(578, 82);
            this.btnMediaTitle.Name = "btnMediaTitle";
            this.btnMediaTitle.Size = new System.Drawing.Size(155, 23);
            this.btnMediaTitle.TabIndex = 8;
            this.btnMediaTitle.Text = "Media Title";
            this.btnMediaTitle.UseVisualStyleBackColor = true;
            this.btnMediaTitle.Click += new System.EventHandler(this.btnMediaTitle_Click);
            // 
            // btnMediaItem
            // 
            this.btnMediaItem.Location = new System.Drawing.Point(578, 112);
            this.btnMediaItem.Name = "btnMediaItem";
            this.btnMediaItem.Size = new System.Drawing.Size(155, 23);
            this.btnMediaItem.TabIndex = 9;
            this.btnMediaItem.Text = "Media Item";
            this.btnMediaItem.UseVisualStyleBackColor = true;
            this.btnMediaItem.Click += new System.EventHandler(this.btnMediaItem_Click);
            // 
            // btnCondition
            // 
            this.btnCondition.Location = new System.Drawing.Point(578, 142);
            this.btnCondition.Name = "btnCondition";
            this.btnCondition.Size = new System.Drawing.Size(155, 23);
            this.btnCondition.TabIndex = 10;
            this.btnCondition.Text = "Condition";
            this.btnCondition.UseVisualStyleBackColor = true;
            this.btnCondition.Click += new System.EventHandler(this.btnCondition_Click);
            // 
            // btnPatrons
            // 
            this.btnPatrons.Location = new System.Drawing.Point(578, 172);
            this.btnPatrons.Name = "btnPatrons";
            this.btnPatrons.Size = new System.Drawing.Size(155, 23);
            this.btnPatrons.TabIndex = 11;
            this.btnPatrons.Text = "Patrons";
            this.btnPatrons.UseVisualStyleBackColor = true;
            this.btnPatrons.Click += new System.EventHandler(this.btnPatrons_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(578, 202);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(155, 23);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // bntFines
            // 
            this.bntFines.Location = new System.Drawing.Point(578, 232);
            this.bntFines.Name = "bntFines";
            this.bntFines.Size = new System.Drawing.Size(155, 23);
            this.bntFines.TabIndex = 13;
            this.bntFines.Text = "Fines";
            this.bntFines.UseVisualStyleBackColor = true;
            this.bntFines.Click += new System.EventHandler(this.bntFines_Click);
            // 
            // patronsDataGridView
            // 
            this.patronsDataGridView.AutoGenerateColumns = false;
            this.patronsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12});
            this.patronsDataGridView.DataSource = this.patronsBindingSource;
            this.patronsDataGridView.Location = new System.Drawing.Point(12, 52);
            this.patronsDataGridView.Name = "patronsDataGridView";
            this.patronsDataGridView.Size = new System.Drawing.Size(544, 203);
            this.patronsDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatronID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatronID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // patronsBindingSource
            // 
            this.patronsBindingSource.DataMember = "Patrons";
            this.patronsBindingSource.DataSource = this.mediaLibraryDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchLbl);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 146);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Patron";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(18, 35);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(132, 13);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Enter a patron\'s last name:";
            // 
            // btnCheckOutHist
            // 
            this.btnCheckOutHist.Location = new System.Drawing.Point(578, 261);
            this.btnCheckOutHist.Name = "btnCheckOutHist";
            this.btnCheckOutHist.Size = new System.Drawing.Size(155, 23);
            this.btnCheckOutHist.TabIndex = 16;
            this.btnCheckOutHist.Text = "Checkout History Report";
            this.btnCheckOutHist.UseVisualStyleBackColor = true;
            this.btnCheckOutHist.Click += new System.EventHandler(this.btnCheckOutHist_Click);
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
            // patronsTableAdapter
            // 
            this.patronsTableAdapter.ClearBeforeFill = true;
            // 
            // LibraryDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 441);
            this.Controls.Add(this.btnCheckOutHist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patronsDataGridView);
            this.Controls.Add(this.bntFines);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnPatrons);
            this.Controls.Add(this.btnCondition);
            this.Controls.Add(this.btnMediaItem);
            this.Controls.Add(this.btnMediaTitle);
            this.Controls.Add(this.btnMediaType);
            this.Controls.Add(this.patronCheckoutsBindingNavigator);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConditionFines);
            this.Controls.Add(this.btnOutstandingItems);
            this.Controls.Add(this.btnOutstandingFines);
            this.Name = "LibraryDatabase";
            this.Text = "Library Database";
            this.Load += new System.EventHandler(this.LibraryDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingNavigator)).EndInit();
            this.patronCheckoutsBindingNavigator.ResumeLayout(false);
            this.patronCheckoutsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutstandingFines;
        private System.Windows.Forms.Button btnOutstandingItems;
        private System.Windows.Forms.Button btnConditionFines;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnShowDetails;
        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource patronCheckoutsBindingSource;
        private MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter patronCheckoutsTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patronCheckoutsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patronCheckoutsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnMediaType;
        private System.Windows.Forms.Button btnMediaTitle;
        private System.Windows.Forms.Button btnMediaItem;
        private System.Windows.Forms.Button btnCondition;
        private System.Windows.Forms.Button btnPatrons;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button bntFines;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private MediaLibraryDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
        private System.Windows.Forms.DataGridView patronsDataGridView;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button btnCheckOutHist;
    }
}