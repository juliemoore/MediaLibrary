namespace MediaLibrary
{
    partial class PatronCheckouts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatronCheckouts));
            System.Windows.Forms.Label patronIDLabel;
            System.Windows.Forms.Label patronFirstNameLabel;
            System.Windows.Forms.Label patronLastNameLabel;
            System.Windows.Forms.Label patronAddress1Label;
            System.Windows.Forms.Label patronAddress2Label;
            System.Windows.Forms.Label patronCityLabel;
            System.Windows.Forms.Label patronStateLabel;
            System.Windows.Forms.Label patronZipcodeLabel;
            System.Windows.Forms.Label patronPhoneLabel;
            System.Windows.Forms.Label patronEmailLabel;
            System.Windows.Forms.Label joinDateLabel;
            System.Windows.Forms.Label inactiveDateLabel;
            System.Windows.Forms.Label checkoutIDLabel;
            System.Windows.Forms.Label mediaItemIDFKLabel;
            System.Windows.Forms.Label patronIDFKLabel;
            System.Windows.Forms.Label outDateLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label outConditionIDFKLabel;
            System.Windows.Forms.Label returnConditionIDFKLabel;
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.patronCheckoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronCheckoutsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronCheckoutsTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.patronCheckoutsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patronCheckoutsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patronIDTextBox = new System.Windows.Forms.TextBox();
            this.patronFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.patronLastNameTextBox = new System.Windows.Forms.TextBox();
            this.patronAddress1TextBox = new System.Windows.Forms.TextBox();
            this.patronAddress2TextBox = new System.Windows.Forms.TextBox();
            this.patronCityTextBox = new System.Windows.Forms.TextBox();
            this.patronStateTextBox = new System.Windows.Forms.TextBox();
            this.patronZipcodeTextBox = new System.Windows.Forms.TextBox();
            this.patronPhoneTextBox = new System.Windows.Forms.TextBox();
            this.patronEmailTextBox = new System.Windows.Forms.TextBox();
            this.joinDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inactiveDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkoutIDTextBox = new System.Windows.Forms.TextBox();
            this.mediaItemIDFKTextBox = new System.Windows.Forms.TextBox();
            this.patronIDFKTextBox = new System.Windows.Forms.TextBox();
            this.outDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.outConditionIDFKTextBox = new System.Windows.Forms.TextBox();
            this.returnConditionIDFKTextBox = new System.Windows.Forms.TextBox();
            patronIDLabel = new System.Windows.Forms.Label();
            patronFirstNameLabel = new System.Windows.Forms.Label();
            patronLastNameLabel = new System.Windows.Forms.Label();
            patronAddress1Label = new System.Windows.Forms.Label();
            patronAddress2Label = new System.Windows.Forms.Label();
            patronCityLabel = new System.Windows.Forms.Label();
            patronStateLabel = new System.Windows.Forms.Label();
            patronZipcodeLabel = new System.Windows.Forms.Label();
            patronPhoneLabel = new System.Windows.Forms.Label();
            patronEmailLabel = new System.Windows.Forms.Label();
            joinDateLabel = new System.Windows.Forms.Label();
            inactiveDateLabel = new System.Windows.Forms.Label();
            checkoutIDLabel = new System.Windows.Forms.Label();
            mediaItemIDFKLabel = new System.Windows.Forms.Label();
            patronIDFKLabel = new System.Windows.Forms.Label();
            outDateLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            outConditionIDFKLabel = new System.Windows.Forms.Label();
            returnConditionIDFKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingNavigator)).BeginInit();
            this.patronCheckoutsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.patronCheckoutsBindingNavigator.Size = new System.Drawing.Size(733, 25);
            this.patronCheckoutsBindingNavigator.TabIndex = 0;
            this.patronCheckoutsBindingNavigator.Text = "bindingNavigator1";
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
            // patronCheckoutsBindingNavigatorSaveItem
            // 
            this.patronCheckoutsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patronCheckoutsBindingNavigatorSaveItem.Enabled = false;
            this.patronCheckoutsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patronCheckoutsBindingNavigatorSaveItem.Image")));
            this.patronCheckoutsBindingNavigatorSaveItem.Name = "patronCheckoutsBindingNavigatorSaveItem";
            this.patronCheckoutsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patronCheckoutsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // patronIDLabel
            // 
            patronIDLabel.AutoSize = true;
            patronIDLabel.Location = new System.Drawing.Point(27, 41);
            patronIDLabel.Name = "patronIDLabel";
            patronIDLabel.Size = new System.Drawing.Size(55, 13);
            patronIDLabel.TabIndex = 1;
            patronIDLabel.Text = "Patron ID:";
            // 
            // patronIDTextBox
            // 
            this.patronIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronID", true));
            this.patronIDTextBox.Location = new System.Drawing.Point(149, 38);
            this.patronIDTextBox.Name = "patronIDTextBox";
            this.patronIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronIDTextBox.TabIndex = 2;
            // 
            // patronFirstNameLabel
            // 
            patronFirstNameLabel.AutoSize = true;
            patronFirstNameLabel.Location = new System.Drawing.Point(27, 67);
            patronFirstNameLabel.Name = "patronFirstNameLabel";
            patronFirstNameLabel.Size = new System.Drawing.Size(94, 13);
            patronFirstNameLabel.TabIndex = 3;
            patronFirstNameLabel.Text = "Patron First Name:";
            // 
            // patronFirstNameTextBox
            // 
            this.patronFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronFirstName", true));
            this.patronFirstNameTextBox.Location = new System.Drawing.Point(149, 64);
            this.patronFirstNameTextBox.Name = "patronFirstNameTextBox";
            this.patronFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronFirstNameTextBox.TabIndex = 4;
            // 
            // patronLastNameLabel
            // 
            patronLastNameLabel.AutoSize = true;
            patronLastNameLabel.Location = new System.Drawing.Point(27, 93);
            patronLastNameLabel.Name = "patronLastNameLabel";
            patronLastNameLabel.Size = new System.Drawing.Size(95, 13);
            patronLastNameLabel.TabIndex = 5;
            patronLastNameLabel.Text = "Patron Last Name:";
            // 
            // patronLastNameTextBox
            // 
            this.patronLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronLastName", true));
            this.patronLastNameTextBox.Location = new System.Drawing.Point(149, 90);
            this.patronLastNameTextBox.Name = "patronLastNameTextBox";
            this.patronLastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronLastNameTextBox.TabIndex = 6;
            // 
            // patronAddress1Label
            // 
            patronAddress1Label.AutoSize = true;
            patronAddress1Label.Location = new System.Drawing.Point(27, 119);
            patronAddress1Label.Name = "patronAddress1Label";
            patronAddress1Label.Size = new System.Drawing.Size(88, 13);
            patronAddress1Label.TabIndex = 7;
            patronAddress1Label.Text = "Patron Address1:";
            // 
            // patronAddress1TextBox
            // 
            this.patronAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronAddress1", true));
            this.patronAddress1TextBox.Location = new System.Drawing.Point(149, 116);
            this.patronAddress1TextBox.Name = "patronAddress1TextBox";
            this.patronAddress1TextBox.Size = new System.Drawing.Size(200, 20);
            this.patronAddress1TextBox.TabIndex = 8;
            // 
            // patronAddress2Label
            // 
            patronAddress2Label.AutoSize = true;
            patronAddress2Label.Location = new System.Drawing.Point(27, 145);
            patronAddress2Label.Name = "patronAddress2Label";
            patronAddress2Label.Size = new System.Drawing.Size(88, 13);
            patronAddress2Label.TabIndex = 9;
            patronAddress2Label.Text = "Patron Address2:";
            // 
            // patronAddress2TextBox
            // 
            this.patronAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronAddress2", true));
            this.patronAddress2TextBox.Location = new System.Drawing.Point(149, 142);
            this.patronAddress2TextBox.Name = "patronAddress2TextBox";
            this.patronAddress2TextBox.Size = new System.Drawing.Size(200, 20);
            this.patronAddress2TextBox.TabIndex = 10;
            // 
            // patronCityLabel
            // 
            patronCityLabel.AutoSize = true;
            patronCityLabel.Location = new System.Drawing.Point(27, 171);
            patronCityLabel.Name = "patronCityLabel";
            patronCityLabel.Size = new System.Drawing.Size(61, 13);
            patronCityLabel.TabIndex = 11;
            patronCityLabel.Text = "Patron City:";
            // 
            // patronCityTextBox
            // 
            this.patronCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronCity", true));
            this.patronCityTextBox.Location = new System.Drawing.Point(149, 168);
            this.patronCityTextBox.Name = "patronCityTextBox";
            this.patronCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronCityTextBox.TabIndex = 12;
            // 
            // patronStateLabel
            // 
            patronStateLabel.AutoSize = true;
            patronStateLabel.Location = new System.Drawing.Point(27, 197);
            patronStateLabel.Name = "patronStateLabel";
            patronStateLabel.Size = new System.Drawing.Size(69, 13);
            patronStateLabel.TabIndex = 13;
            patronStateLabel.Text = "Patron State:";
            // 
            // patronStateTextBox
            // 
            this.patronStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronState", true));
            this.patronStateTextBox.Location = new System.Drawing.Point(149, 194);
            this.patronStateTextBox.Name = "patronStateTextBox";
            this.patronStateTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronStateTextBox.TabIndex = 14;
            // 
            // patronZipcodeLabel
            // 
            patronZipcodeLabel.AutoSize = true;
            patronZipcodeLabel.Location = new System.Drawing.Point(27, 223);
            patronZipcodeLabel.Name = "patronZipcodeLabel";
            patronZipcodeLabel.Size = new System.Drawing.Size(83, 13);
            patronZipcodeLabel.TabIndex = 15;
            patronZipcodeLabel.Text = "Patron Zipcode:";
            // 
            // patronZipcodeTextBox
            // 
            this.patronZipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronZipcode", true));
            this.patronZipcodeTextBox.Location = new System.Drawing.Point(149, 220);
            this.patronZipcodeTextBox.Name = "patronZipcodeTextBox";
            this.patronZipcodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronZipcodeTextBox.TabIndex = 16;
            // 
            // patronPhoneLabel
            // 
            patronPhoneLabel.AutoSize = true;
            patronPhoneLabel.Location = new System.Drawing.Point(27, 249);
            patronPhoneLabel.Name = "patronPhoneLabel";
            patronPhoneLabel.Size = new System.Drawing.Size(75, 13);
            patronPhoneLabel.TabIndex = 17;
            patronPhoneLabel.Text = "Patron Phone:";
            // 
            // patronPhoneTextBox
            // 
            this.patronPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronPhone", true));
            this.patronPhoneTextBox.Location = new System.Drawing.Point(149, 246);
            this.patronPhoneTextBox.Name = "patronPhoneTextBox";
            this.patronPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronPhoneTextBox.TabIndex = 18;
            // 
            // patronEmailLabel
            // 
            patronEmailLabel.AutoSize = true;
            patronEmailLabel.Location = new System.Drawing.Point(27, 275);
            patronEmailLabel.Name = "patronEmailLabel";
            patronEmailLabel.Size = new System.Drawing.Size(69, 13);
            patronEmailLabel.TabIndex = 19;
            patronEmailLabel.Text = "Patron Email:";
            // 
            // patronEmailTextBox
            // 
            this.patronEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronEmail", true));
            this.patronEmailTextBox.Location = new System.Drawing.Point(149, 272);
            this.patronEmailTextBox.Name = "patronEmailTextBox";
            this.patronEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronEmailTextBox.TabIndex = 20;
            // 
            // joinDateLabel
            // 
            joinDateLabel.AutoSize = true;
            joinDateLabel.Location = new System.Drawing.Point(27, 302);
            joinDateLabel.Name = "joinDateLabel";
            joinDateLabel.Size = new System.Drawing.Size(55, 13);
            joinDateLabel.TabIndex = 21;
            joinDateLabel.Text = "Join Date:";
            // 
            // joinDateDateTimePicker
            // 
            this.joinDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patronCheckoutsBindingSource, "JoinDate", true));
            this.joinDateDateTimePicker.Location = new System.Drawing.Point(149, 298);
            this.joinDateDateTimePicker.Name = "joinDateDateTimePicker";
            this.joinDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.joinDateDateTimePicker.TabIndex = 22;
            // 
            // inactiveDateLabel
            // 
            inactiveDateLabel.AutoSize = true;
            inactiveDateLabel.Location = new System.Drawing.Point(27, 328);
            inactiveDateLabel.Name = "inactiveDateLabel";
            inactiveDateLabel.Size = new System.Drawing.Size(74, 13);
            inactiveDateLabel.TabIndex = 23;
            inactiveDateLabel.Text = "Inactive Date:";
            // 
            // inactiveDateDateTimePicker
            // 
            this.inactiveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patronCheckoutsBindingSource, "InactiveDate", true));
            this.inactiveDateDateTimePicker.Location = new System.Drawing.Point(149, 324);
            this.inactiveDateDateTimePicker.Name = "inactiveDateDateTimePicker";
            this.inactiveDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.inactiveDateDateTimePicker.TabIndex = 24;
            // 
            // checkoutIDLabel
            // 
            checkoutIDLabel.AutoSize = true;
            checkoutIDLabel.Location = new System.Drawing.Point(382, 44);
            checkoutIDLabel.Name = "checkoutIDLabel";
            checkoutIDLabel.Size = new System.Drawing.Size(70, 13);
            checkoutIDLabel.TabIndex = 25;
            checkoutIDLabel.Text = "Checkout ID:";
            // 
            // checkoutIDTextBox
            // 
            this.checkoutIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "CheckoutID", true));
            this.checkoutIDTextBox.Location = new System.Drawing.Point(504, 41);
            this.checkoutIDTextBox.Name = "checkoutIDTextBox";
            this.checkoutIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.checkoutIDTextBox.TabIndex = 26;
            // 
            // mediaItemIDFKLabel
            // 
            mediaItemIDFKLabel.AutoSize = true;
            mediaItemIDFKLabel.Location = new System.Drawing.Point(382, 70);
            mediaItemIDFKLabel.Name = "mediaItemIDFKLabel";
            mediaItemIDFKLabel.Size = new System.Drawing.Size(89, 13);
            mediaItemIDFKLabel.TabIndex = 27;
            mediaItemIDFKLabel.Text = "Media Item IDFK:";
            // 
            // mediaItemIDFKTextBox
            // 
            this.mediaItemIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "MediaItemIDFK", true));
            this.mediaItemIDFKTextBox.Location = new System.Drawing.Point(504, 67);
            this.mediaItemIDFKTextBox.Name = "mediaItemIDFKTextBox";
            this.mediaItemIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.mediaItemIDFKTextBox.TabIndex = 28;
            // 
            // patronIDFKLabel
            // 
            patronIDFKLabel.AutoSize = true;
            patronIDFKLabel.Location = new System.Drawing.Point(382, 96);
            patronIDFKLabel.Name = "patronIDFKLabel";
            patronIDFKLabel.Size = new System.Drawing.Size(68, 13);
            patronIDFKLabel.TabIndex = 29;
            patronIDFKLabel.Text = "Patron IDFK:";
            // 
            // patronIDFKTextBox
            // 
            this.patronIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "PatronIDFK", true));
            this.patronIDFKTextBox.Location = new System.Drawing.Point(504, 93);
            this.patronIDFKTextBox.Name = "patronIDFKTextBox";
            this.patronIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronIDFKTextBox.TabIndex = 30;
            // 
            // outDateLabel
            // 
            outDateLabel.AutoSize = true;
            outDateLabel.Location = new System.Drawing.Point(382, 123);
            outDateLabel.Name = "outDateLabel";
            outDateLabel.Size = new System.Drawing.Size(53, 13);
            outDateLabel.TabIndex = 31;
            outDateLabel.Text = "Out Date:";
            // 
            // outDateDateTimePicker
            // 
            this.outDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patronCheckoutsBindingSource, "OutDate", true));
            this.outDateDateTimePicker.Location = new System.Drawing.Point(504, 119);
            this.outDateDateTimePicker.Name = "outDateDateTimePicker";
            this.outDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.outDateDateTimePicker.TabIndex = 32;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(382, 149);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 33;
            dueDateLabel.Text = "Due Date:";
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patronCheckoutsBindingSource, "DueDate", true));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(504, 145);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDateTimePicker.TabIndex = 34;
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(382, 175);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(68, 13);
            returnDateLabel.TabIndex = 35;
            returnDateLabel.Text = "Return Date:";
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patronCheckoutsBindingSource, "ReturnDate", true));
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(504, 171);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDateDateTimePicker.TabIndex = 36;
            // 
            // outConditionIDFKLabel
            // 
            outConditionIDFKLabel.AutoSize = true;
            outConditionIDFKLabel.Location = new System.Drawing.Point(382, 200);
            outConditionIDFKLabel.Name = "outConditionIDFKLabel";
            outConditionIDFKLabel.Size = new System.Drawing.Size(101, 13);
            outConditionIDFKLabel.TabIndex = 37;
            outConditionIDFKLabel.Text = "Out Condition IDFK:";
            // 
            // outConditionIDFKTextBox
            // 
            this.outConditionIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "OutConditionIDFK", true));
            this.outConditionIDFKTextBox.Location = new System.Drawing.Point(504, 197);
            this.outConditionIDFKTextBox.Name = "outConditionIDFKTextBox";
            this.outConditionIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.outConditionIDFKTextBox.TabIndex = 38;
            // 
            // returnConditionIDFKLabel
            // 
            returnConditionIDFKLabel.AutoSize = true;
            returnConditionIDFKLabel.Location = new System.Drawing.Point(382, 226);
            returnConditionIDFKLabel.Name = "returnConditionIDFKLabel";
            returnConditionIDFKLabel.Size = new System.Drawing.Size(116, 13);
            returnConditionIDFKLabel.TabIndex = 39;
            returnConditionIDFKLabel.Text = "Return Condition IDFK:";
            // 
            // returnConditionIDFKTextBox
            // 
            this.returnConditionIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronCheckoutsBindingSource, "ReturnConditionIDFK", true));
            this.returnConditionIDFKTextBox.Location = new System.Drawing.Point(504, 223);
            this.returnConditionIDFKTextBox.Name = "returnConditionIDFKTextBox";
            this.returnConditionIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.returnConditionIDFKTextBox.TabIndex = 40;
            // 
            // PatronCheckouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 365);
            this.Controls.Add(patronIDLabel);
            this.Controls.Add(this.patronIDTextBox);
            this.Controls.Add(patronFirstNameLabel);
            this.Controls.Add(this.patronFirstNameTextBox);
            this.Controls.Add(patronLastNameLabel);
            this.Controls.Add(this.patronLastNameTextBox);
            this.Controls.Add(patronAddress1Label);
            this.Controls.Add(this.patronAddress1TextBox);
            this.Controls.Add(patronAddress2Label);
            this.Controls.Add(this.patronAddress2TextBox);
            this.Controls.Add(patronCityLabel);
            this.Controls.Add(this.patronCityTextBox);
            this.Controls.Add(patronStateLabel);
            this.Controls.Add(this.patronStateTextBox);
            this.Controls.Add(patronZipcodeLabel);
            this.Controls.Add(this.patronZipcodeTextBox);
            this.Controls.Add(patronPhoneLabel);
            this.Controls.Add(this.patronPhoneTextBox);
            this.Controls.Add(patronEmailLabel);
            this.Controls.Add(this.patronEmailTextBox);
            this.Controls.Add(joinDateLabel);
            this.Controls.Add(this.joinDateDateTimePicker);
            this.Controls.Add(inactiveDateLabel);
            this.Controls.Add(this.inactiveDateDateTimePicker);
            this.Controls.Add(checkoutIDLabel);
            this.Controls.Add(this.checkoutIDTextBox);
            this.Controls.Add(mediaItemIDFKLabel);
            this.Controls.Add(this.mediaItemIDFKTextBox);
            this.Controls.Add(patronIDFKLabel);
            this.Controls.Add(this.patronIDFKTextBox);
            this.Controls.Add(outDateLabel);
            this.Controls.Add(this.outDateDateTimePicker);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(returnDateLabel);
            this.Controls.Add(this.returnDateDateTimePicker);
            this.Controls.Add(outConditionIDFKLabel);
            this.Controls.Add(this.outConditionIDFKTextBox);
            this.Controls.Add(returnConditionIDFKLabel);
            this.Controls.Add(this.returnConditionIDFKTextBox);
            this.Controls.Add(this.patronCheckoutsBindingNavigator);
            this.Name = "PatronCheckouts";
            this.Text = "PatronCheckouts";
            this.Load += new System.EventHandler(this.PatronCheckouts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronCheckoutsBindingNavigator)).EndInit();
            this.patronCheckoutsBindingNavigator.ResumeLayout(false);
            this.patronCheckoutsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox patronIDTextBox;
        private System.Windows.Forms.TextBox patronFirstNameTextBox;
        private System.Windows.Forms.TextBox patronLastNameTextBox;
        private System.Windows.Forms.TextBox patronAddress1TextBox;
        private System.Windows.Forms.TextBox patronAddress2TextBox;
        private System.Windows.Forms.TextBox patronCityTextBox;
        private System.Windows.Forms.TextBox patronStateTextBox;
        private System.Windows.Forms.TextBox patronZipcodeTextBox;
        private System.Windows.Forms.TextBox patronPhoneTextBox;
        private System.Windows.Forms.TextBox patronEmailTextBox;
        private System.Windows.Forms.DateTimePicker joinDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker inactiveDateDateTimePicker;
        private System.Windows.Forms.TextBox checkoutIDTextBox;
        private System.Windows.Forms.TextBox mediaItemIDFKTextBox;
        private System.Windows.Forms.TextBox patronIDFKTextBox;
        private System.Windows.Forms.DateTimePicker outDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.TextBox outConditionIDFKTextBox;
        private System.Windows.Forms.TextBox returnConditionIDFKTextBox;
    }
}