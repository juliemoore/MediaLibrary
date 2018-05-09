namespace MediaLibrary
{
    partial class Patrons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patrons));
            this.mediaLibraryDataSet = new MediaLibrary.MediaLibraryDataSet();
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronsTableAdapter = new MediaLibrary.MediaLibraryDataSetTableAdapters.PatronsTableAdapter();
            this.tableAdapterManager = new MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager();
            this.patronsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patronsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).BeginInit();
            this.patronsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // patronIDLabel
            // 
            patronIDLabel.AutoSize = true;
            patronIDLabel.Location = new System.Drawing.Point(44, 46);
            patronIDLabel.Name = "patronIDLabel";
            patronIDLabel.Size = new System.Drawing.Size(55, 13);
            patronIDLabel.TabIndex = 1;
            patronIDLabel.Text = "Patron ID:";
            // 
            // patronFirstNameLabel
            // 
            patronFirstNameLabel.AutoSize = true;
            patronFirstNameLabel.Location = new System.Drawing.Point(44, 72);
            patronFirstNameLabel.Name = "patronFirstNameLabel";
            patronFirstNameLabel.Size = new System.Drawing.Size(94, 13);
            patronFirstNameLabel.TabIndex = 3;
            patronFirstNameLabel.Text = "Patron First Name:";
            // 
            // patronLastNameLabel
            // 
            patronLastNameLabel.AutoSize = true;
            patronLastNameLabel.Location = new System.Drawing.Point(44, 98);
            patronLastNameLabel.Name = "patronLastNameLabel";
            patronLastNameLabel.Size = new System.Drawing.Size(95, 13);
            patronLastNameLabel.TabIndex = 5;
            patronLastNameLabel.Text = "Patron Last Name:";
            // 
            // patronAddress1Label
            // 
            patronAddress1Label.AutoSize = true;
            patronAddress1Label.Location = new System.Drawing.Point(44, 124);
            patronAddress1Label.Name = "patronAddress1Label";
            patronAddress1Label.Size = new System.Drawing.Size(88, 13);
            patronAddress1Label.TabIndex = 7;
            patronAddress1Label.Text = "Patron Address1:";
            // 
            // patronAddress2Label
            // 
            patronAddress2Label.AutoSize = true;
            patronAddress2Label.Location = new System.Drawing.Point(44, 150);
            patronAddress2Label.Name = "patronAddress2Label";
            patronAddress2Label.Size = new System.Drawing.Size(88, 13);
            patronAddress2Label.TabIndex = 9;
            patronAddress2Label.Text = "Patron Address2:";
            // 
            // patronCityLabel
            // 
            patronCityLabel.AutoSize = true;
            patronCityLabel.Location = new System.Drawing.Point(44, 176);
            patronCityLabel.Name = "patronCityLabel";
            patronCityLabel.Size = new System.Drawing.Size(61, 13);
            patronCityLabel.TabIndex = 11;
            patronCityLabel.Text = "Patron City:";
            // 
            // patronStateLabel
            // 
            patronStateLabel.AutoSize = true;
            patronStateLabel.Location = new System.Drawing.Point(44, 202);
            patronStateLabel.Name = "patronStateLabel";
            patronStateLabel.Size = new System.Drawing.Size(69, 13);
            patronStateLabel.TabIndex = 13;
            patronStateLabel.Text = "Patron State:";
            // 
            // patronZipcodeLabel
            // 
            patronZipcodeLabel.AutoSize = true;
            patronZipcodeLabel.Location = new System.Drawing.Point(44, 228);
            patronZipcodeLabel.Name = "patronZipcodeLabel";
            patronZipcodeLabel.Size = new System.Drawing.Size(83, 13);
            patronZipcodeLabel.TabIndex = 15;
            patronZipcodeLabel.Text = "Patron Zipcode:";
            // 
            // patronPhoneLabel
            // 
            patronPhoneLabel.AutoSize = true;
            patronPhoneLabel.Location = new System.Drawing.Point(44, 254);
            patronPhoneLabel.Name = "patronPhoneLabel";
            patronPhoneLabel.Size = new System.Drawing.Size(75, 13);
            patronPhoneLabel.TabIndex = 17;
            patronPhoneLabel.Text = "Patron Phone:";
            // 
            // patronEmailLabel
            // 
            patronEmailLabel.AutoSize = true;
            patronEmailLabel.Location = new System.Drawing.Point(44, 280);
            patronEmailLabel.Name = "patronEmailLabel";
            patronEmailLabel.Size = new System.Drawing.Size(69, 13);
            patronEmailLabel.TabIndex = 19;
            patronEmailLabel.Text = "Patron Email:";
            // 
            // joinDateLabel
            // 
            joinDateLabel.AutoSize = true;
            joinDateLabel.Location = new System.Drawing.Point(44, 307);
            joinDateLabel.Name = "joinDateLabel";
            joinDateLabel.Size = new System.Drawing.Size(55, 13);
            joinDateLabel.TabIndex = 21;
            joinDateLabel.Text = "Join Date:";
            // 
            // inactiveDateLabel
            // 
            inactiveDateLabel.AutoSize = true;
            inactiveDateLabel.Location = new System.Drawing.Point(44, 333);
            inactiveDateLabel.Name = "inactiveDateLabel";
            inactiveDateLabel.Size = new System.Drawing.Size(74, 13);
            inactiveDateLabel.TabIndex = 23;
            inactiveDateLabel.Text = "Inactive Date:";
            // 
            // mediaLibraryDataSet
            // 
            this.mediaLibraryDataSet.DataSetName = "MediaLibraryDataSet";
            this.mediaLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckoutTableAdapter = null;
            this.tableAdapterManager.ConditionTableAdapter = null;
            this.tableAdapterManager.FinesTableAdapter = null;
            this.tableAdapterManager.MediaItemTableAdapter = null;
            this.tableAdapterManager.MediaTitleTableAdapter = null;
            this.tableAdapterManager.MediaTypeTableAdapter = null;
            this.tableAdapterManager.PatronsTableAdapter = this.patronsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MediaLibrary.MediaLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patronsBindingNavigator
            // 
            this.patronsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patronsBindingNavigator.BindingSource = this.patronsBindingSource;
            this.patronsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patronsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patronsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patronsBindingNavigatorSaveItem});
            this.patronsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patronsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patronsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patronsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patronsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patronsBindingNavigator.Name = "patronsBindingNavigator";
            this.patronsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patronsBindingNavigator.Size = new System.Drawing.Size(427, 25);
            this.patronsBindingNavigator.TabIndex = 0;
            this.patronsBindingNavigator.Text = "bindingNavigator1";
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
            // patronsBindingNavigatorSaveItem
            // 
            this.patronsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patronsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patronsBindingNavigatorSaveItem.Image")));
            this.patronsBindingNavigatorSaveItem.Name = "patronsBindingNavigatorSaveItem";
            this.patronsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patronsBindingNavigatorSaveItem.Text = "Save Data";
            this.patronsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patronsBindingNavigatorSaveItem_Click_1);
            // 
            // patronIDTextBox
            // 
            this.patronIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronID", true));
            this.patronIDTextBox.Location = new System.Drawing.Point(145, 43);
            this.patronIDTextBox.Name = "patronIDTextBox";
            this.patronIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronIDTextBox.TabIndex = 2;
            // 
            // patronFirstNameTextBox
            // 
            this.patronFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronFirstName", true));
            this.patronFirstNameTextBox.Location = new System.Drawing.Point(145, 69);
            this.patronFirstNameTextBox.Name = "patronFirstNameTextBox";
            this.patronFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronFirstNameTextBox.TabIndex = 4;
            // 
            // patronLastNameTextBox
            // 
            this.patronLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronLastName", true));
            this.patronLastNameTextBox.Location = new System.Drawing.Point(145, 95);
            this.patronLastNameTextBox.Name = "patronLastNameTextBox";
            this.patronLastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronLastNameTextBox.TabIndex = 6;
            // 
            // patronAddress1TextBox
            // 
            this.patronAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronAddress1", true));
            this.patronAddress1TextBox.Location = new System.Drawing.Point(145, 121);
            this.patronAddress1TextBox.Name = "patronAddress1TextBox";
            this.patronAddress1TextBox.Size = new System.Drawing.Size(200, 20);
            this.patronAddress1TextBox.TabIndex = 8;
            // 
            // patronAddress2TextBox
            // 
            this.patronAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronAddress2", true));
            this.patronAddress2TextBox.Location = new System.Drawing.Point(145, 147);
            this.patronAddress2TextBox.Name = "patronAddress2TextBox";
            this.patronAddress2TextBox.Size = new System.Drawing.Size(200, 20);
            this.patronAddress2TextBox.TabIndex = 10;
            // 
            // patronCityTextBox
            // 
            this.patronCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronCity", true));
            this.patronCityTextBox.Location = new System.Drawing.Point(145, 173);
            this.patronCityTextBox.Name = "patronCityTextBox";
            this.patronCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronCityTextBox.TabIndex = 12;
            // 
            // patronStateTextBox
            // 
            this.patronStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronState", true));
            this.patronStateTextBox.Location = new System.Drawing.Point(145, 199);
            this.patronStateTextBox.Name = "patronStateTextBox";
            this.patronStateTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronStateTextBox.TabIndex = 14;
            // 
            // patronZipcodeTextBox
            // 
            this.patronZipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronZipcode", true));
            this.patronZipcodeTextBox.Location = new System.Drawing.Point(145, 225);
            this.patronZipcodeTextBox.Name = "patronZipcodeTextBox";
            this.patronZipcodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronZipcodeTextBox.TabIndex = 16;
            // 
            // patronPhoneTextBox
            // 
            this.patronPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronPhone", true));
            this.patronPhoneTextBox.Location = new System.Drawing.Point(145, 251);
            this.patronPhoneTextBox.Name = "patronPhoneTextBox";
            this.patronPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronPhoneTextBox.TabIndex = 18;
            // 
            // patronEmailTextBox
            // 
            this.patronEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "PatronEmail", true));
            this.patronEmailTextBox.Location = new System.Drawing.Point(145, 277);
            this.patronEmailTextBox.Name = "patronEmailTextBox";
            this.patronEmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronEmailTextBox.TabIndex = 20;
            // 
            // joinDateDateTimePicker
            // 
            this.joinDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patronsBindingSource, "JoinDate", true));
            this.joinDateDateTimePicker.Location = new System.Drawing.Point(145, 303);
            this.joinDateDateTimePicker.Name = "joinDateDateTimePicker";
            this.joinDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.joinDateDateTimePicker.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "InactiveDate", true));
            this.textBox1.Location = new System.Drawing.Point(145, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 26;
            // 
            // Patrons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 402);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
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
            this.Controls.Add(this.patronsBindingNavigator);
            this.Name = "Patrons";
            this.Text = "Patrons";
            this.Load += new System.EventHandler(this.Patrons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).EndInit();
            this.patronsBindingNavigator.ResumeLayout(false);
            this.patronsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaLibraryDataSet mediaLibraryDataSet;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private MediaLibraryDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
        private MediaLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patronsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patronsBindingNavigatorSaveItem;
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
    }
}