namespace Party_Planner_Application
{
    partial class Party_Form
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
            System.Windows.Forms.Label party_NameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label itemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Party_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemovePartyButton = new System.Windows.Forms.Button();
            this.party_NameTextBox = new System.Windows.Forms.TextBox();
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyDatabaseDataSet = new Party_Planner_Application.PartyDatabaseDataSet();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.partyReportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemLabel1 = new System.Windows.Forms.Label();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_NameLabel1 = new System.Windows.Forms.Label();
            this.first_NameLabel1 = new System.Windows.Forms.Label();
            this.manageGuestButton = new System.Windows.Forms.Button();
            this.guestListBox = new System.Windows.Forms.ListBox();
            this.addGuestButton = new System.Windows.Forms.Button();
            this.guestLabel = new System.Windows.Forms.Panel();
            this.guestsLabel2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeItem = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addSupplyButton = new System.Windows.Forms.Button();
            this.supplyLabel = new System.Windows.Forms.Panel();
            this.suppliesLabel2 = new System.Windows.Forms.Label();
            this.partiesTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.PartiesTableAdapter();
            this.tableAdapterManager = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.guestsTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.GuestsTableAdapter();
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
            this.partiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.itemsTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.ItemsTableAdapter();
            this.guestsTableAdapter1 = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.GuestsTableAdapter();
            party_NameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            this.guestLabel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.supplyLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingNavigator)).BeginInit();
            this.partiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // party_NameLabel
            // 
            party_NameLabel.AutoSize = true;
            party_NameLabel.BackColor = System.Drawing.SystemColors.Control;
            party_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            party_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            party_NameLabel.Location = new System.Drawing.Point(161, 128);
            party_NameLabel.Name = "party_NameLabel";
            party_NameLabel.Size = new System.Drawing.Size(144, 29);
            party_NameLabel.TabIndex = 12;
            party_NameLabel.Text = "Party Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = System.Drawing.SystemColors.Control;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            dateLabel.Location = new System.Drawing.Point(161, 185);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(69, 29);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "Date:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = System.Drawing.SystemColors.Control;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            locationLabel.Location = new System.Drawing.Point(161, 242);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(110, 29);
            locationLabel.TabIndex = 16;
            locationLabel.Text = "Location:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            first_NameLabel.Location = new System.Drawing.Point(336, 190);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(137, 29);
            first_NameLabel.TabIndex = 13;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            last_NameLabel.Location = new System.Drawing.Point(336, 268);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(134, 29);
            last_NameLabel.TabIndex = 14;
            last_NameLabel.Text = "Last Name:";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            itemLabel.Location = new System.Drawing.Point(336, 344);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(65, 29);
            itemLabel.TabIndex = 15;
            itemLabel.Text = "Item:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.RemovePartyButton);
            this.panel1.Controls.Add(party_NameLabel);
            this.panel1.Controls.Add(this.party_NameTextBox);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(this.dateDateTimePicker);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationTextBox);
            this.panel1.Controls.Add(this.partyReportButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.MaximumSize = new System.Drawing.Size(1401, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 449);
            this.panel1.TabIndex = 0;
            // 
            // RemovePartyButton
            // 
            this.RemovePartyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePartyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RemovePartyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemovePartyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePartyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemovePartyButton.Location = new System.Drawing.Point(1039, 358);
            this.RemovePartyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemovePartyButton.Name = "RemovePartyButton";
            this.RemovePartyButton.Size = new System.Drawing.Size(363, 80);
            this.RemovePartyButton.TabIndex = 18;
            this.RemovePartyButton.Text = "Remove Party";
            this.RemovePartyButton.UseVisualStyleBackColor = false;
            this.RemovePartyButton.Click += new System.EventHandler(this.RemovePartyButton_Click);
            // 
            // party_NameTextBox
            // 
            this.party_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesBindingSource, "Party Name", true));
            this.party_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_NameTextBox.Location = new System.Drawing.Point(341, 125);
            this.party_NameTextBox.Name = "party_NameTextBox";
            this.party_NameTextBox.Size = new System.Drawing.Size(423, 35);
            this.party_NameTextBox.TabIndex = 13;
            // 
            // partiesBindingSource
            // 
            this.partiesBindingSource.DataMember = "Parties";
            this.partiesBindingSource.DataSource = this.partyDatabaseDataSet;
            // 
            // partyDatabaseDataSet
            // 
            this.partyDatabaseDataSet.DataSetName = "PartyDatabaseDataSet";
            this.partyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(341, 185);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(423, 35);
            this.dateDateTimePicker.TabIndex = 15;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesBindingSource, "Location", true));
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(341, 242);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(423, 35);
            this.locationTextBox.TabIndex = 17;
            // 
            // partyReportButton
            // 
            this.partyReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partyReportButton.BackColor = System.Drawing.SystemColors.Control;
            this.partyReportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.partyReportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partyReportButton.Location = new System.Drawing.Point(1038, 268);
            this.partyReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partyReportButton.Name = "partyReportButton";
            this.partyReportButton.Size = new System.Drawing.Size(363, 80);
            this.partyReportButton.TabIndex = 10;
            this.partyReportButton.Text = "Party Report";
            this.partyReportButton.UseVisualStyleBackColor = false;
            this.partyReportButton.Click += new System.EventHandler(this.partyReportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(1038, 80);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(363, 80);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(1038, -2);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(363, 80);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(itemLabel);
            this.panel2.Controls.Add(this.itemLabel1);
            this.panel2.Controls.Add(last_NameLabel);
            this.panel2.Controls.Add(this.last_NameLabel1);
            this.panel2.Controls.Add(first_NameLabel);
            this.panel2.Controls.Add(this.first_NameLabel1);
            this.panel2.Controls.Add(this.manageGuestButton);
            this.panel2.Controls.Add(this.guestListBox);
            this.panel2.Controls.Add(this.addGuestButton);
            this.panel2.Controls.Add(this.guestLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 449);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 601);
            this.panel2.TabIndex = 1;
            // 
            // itemLabel1
            // 
            this.itemLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "Item", true));
            this.itemLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemLabel1.Location = new System.Drawing.Point(476, 344);
            this.itemLabel1.Name = "itemLabel1";
            this.itemLabel1.Size = new System.Drawing.Size(185, 29);
            this.itemLabel1.TabIndex = 16;
            this.itemLabel1.Text = "label1";
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.partyDatabaseDataSet;
            // 
            // last_NameLabel1
            // 
            this.last_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "Last Name", true));
            this.last_NameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.last_NameLabel1.Location = new System.Drawing.Point(476, 268);
            this.last_NameLabel1.Name = "last_NameLabel1";
            this.last_NameLabel1.Size = new System.Drawing.Size(185, 33);
            this.last_NameLabel1.TabIndex = 15;
            this.last_NameLabel1.Text = "label1";
            // 
            // first_NameLabel1
            // 
            this.first_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "First Name", true));
            this.first_NameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.first_NameLabel1.Location = new System.Drawing.Point(479, 190);
            this.first_NameLabel1.Name = "first_NameLabel1";
            this.first_NameLabel1.Size = new System.Drawing.Size(190, 29);
            this.first_NameLabel1.TabIndex = 14;
            this.first_NameLabel1.Text = "label1";
            // 
            // manageGuestButton
            // 
            this.manageGuestButton.BackColor = System.Drawing.SystemColors.Control;
            this.manageGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageGuestButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manageGuestButton.Location = new System.Drawing.Point(0, 388);
            this.manageGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageGuestButton.Name = "manageGuestButton";
            this.manageGuestButton.Size = new System.Drawing.Size(702, 64);
            this.manageGuestButton.TabIndex = 13;
            this.manageGuestButton.Text = "Manage Guest";
            this.manageGuestButton.UseVisualStyleBackColor = false;
            this.manageGuestButton.Click += new System.EventHandler(this.manageGuestButton_Click);
            // 
            // guestListBox
            // 
            this.guestListBox.BackColor = System.Drawing.SystemColors.Control;
            this.guestListBox.DataSource = this.guestsBindingSource;
            this.guestListBox.DisplayMember = "First Name";
            this.guestListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guestListBox.FormattingEnabled = true;
            this.guestListBox.ItemHeight = 29;
            this.guestListBox.Location = new System.Drawing.Point(12, 173);
            this.guestListBox.Name = "guestListBox";
            this.guestListBox.Size = new System.Drawing.Size(292, 207);
            this.guestListBox.TabIndex = 12;
            this.guestListBox.ValueMember = "GuestId";
            // 
            // addGuestButton
            // 
            this.addGuestButton.BackColor = System.Drawing.SystemColors.Control;
            this.addGuestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addGuestButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addGuestButton.Location = new System.Drawing.Point(0, 80);
            this.addGuestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(702, 80);
            this.addGuestButton.TabIndex = 11;
            this.addGuestButton.Text = "Add Guest";
            this.addGuestButton.UseVisualStyleBackColor = false;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // guestLabel
            // 
            this.guestLabel.BackColor = System.Drawing.SystemColors.Control;
            this.guestLabel.Controls.Add(this.guestsLabel2);
            this.guestLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.guestLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guestLabel.Location = new System.Drawing.Point(0, 0);
            this.guestLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(702, 80);
            this.guestLabel.TabIndex = 0;
            // 
            // guestsLabel2
            // 
            this.guestsLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guestsLabel2.AutoSize = true;
            this.guestsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsLabel2.Location = new System.Drawing.Point(302, 23);
            this.guestsLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestsLabel2.Name = "guestsLabel2";
            this.guestsLabel2.Size = new System.Drawing.Size(88, 29);
            this.guestsLabel2.TabIndex = 0;
            this.guestsLabel2.Text = "Guests";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.removeItem);
            this.panel3.Controls.Add(this.AddItemButton);
            this.panel3.Controls.Add(this.ItemTextBox);
            this.panel3.Controls.Add(this.ItemBox);
            this.panel3.Controls.Add(this.addSupplyButton);
            this.panel3.Controls.Add(this.supplyLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(703, 449);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 601);
            this.panel3.TabIndex = 2;
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(20, 405);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(639, 61);
            this.removeItem.TabIndex = 15;
            this.removeItem.Text = "Remove Item";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Visible = false;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(429, 173);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(113, 30);
            this.AddItemButton.TabIndex = 14;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Visible = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTextBox.Location = new System.Drawing.Point(187, 173);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(213, 30);
            this.ItemTextBox.TabIndex = 13;
            this.ItemTextBox.Visible = false;
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.SystemColors.Control;
            this.ItemBox.DataSource = this.itemsBindingSource;
            this.ItemBox.DisplayMember = "Item Name";
            this.ItemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.ItemHeight = 29;
            this.ItemBox.Location = new System.Drawing.Point(20, 216);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(639, 178);
            this.ItemBox.TabIndex = 12;
            this.ItemBox.ValueMember = "Item Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.partyDatabaseDataSet;
            // 
            // addSupplyButton
            // 
            this.addSupplyButton.BackColor = System.Drawing.SystemColors.Control;
            this.addSupplyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSupplyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupplyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addSupplyButton.Location = new System.Drawing.Point(0, 80);
            this.addSupplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSupplyButton.Name = "addSupplyButton";
            this.addSupplyButton.Size = new System.Drawing.Size(699, 80);
            this.addSupplyButton.TabIndex = 11;
            this.addSupplyButton.Text = "Add Items";
            this.addSupplyButton.UseVisualStyleBackColor = false;
            this.addSupplyButton.Click += new System.EventHandler(this.addSupplyButton_Click);
            // 
            // supplyLabel
            // 
            this.supplyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.supplyLabel.Controls.Add(this.suppliesLabel2);
            this.supplyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplyLabel.Location = new System.Drawing.Point(0, 0);
            this.supplyLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supplyLabel.Name = "supplyLabel";
            this.supplyLabel.Size = new System.Drawing.Size(699, 80);
            this.supplyLabel.TabIndex = 0;
            // 
            // suppliesLabel2
            // 
            this.suppliesLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliesLabel2.AutoSize = true;
            this.suppliesLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliesLabel2.Location = new System.Drawing.Point(292, 23);
            this.suppliesLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suppliesLabel2.Name = "suppliesLabel2";
            this.suppliesLabel2.Size = new System.Drawing.Size(108, 29);
            this.suppliesLabel2.TabIndex = 0;
            this.suppliesLabel2.Text = "Supplies";
            // 
            // partiesTableAdapter
            // 
            this.partiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GuestsTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.PartiesTableAdapter = this.partiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Party_Planner_Application.PartyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // partiesBindingNavigatorSaveItem
            // 
            this.partiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partiesBindingNavigatorSaveItem.Image")));
            this.partiesBindingNavigatorSaveItem.Name = "partiesBindingNavigatorSaveItem";
            this.partiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.partiesBindingNavigatorSaveItem.Text = "Save Data";
            this.partiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.partiesBindingNavigatorSaveItem_Click);
            // 
            // partiesBindingNavigator
            // 
            this.partiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partiesBindingNavigator.BindingSource = this.partiesBindingSource;
            this.partiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partiesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.partiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partiesBindingNavigatorSaveItem});
            this.partiesBindingNavigator.Location = new System.Drawing.Point(702, 449);
            this.partiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partiesBindingNavigator.Name = "partiesBindingNavigator";
            this.partiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partiesBindingNavigator.Size = new System.Drawing.Size(1, 35);
            this.partiesBindingNavigator.TabIndex = 3;
            this.partiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // guestsTableAdapter1
            // 
            this.guestsTableAdapter1.ClearBeforeFill = true;
            // 
            // Party_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1402, 1050);
            this.Controls.Add(this.partiesBindingNavigator);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1424, 1106);
            this.MinimumSize = new System.Drawing.Size(1424, 1018);
            this.Name = "Party_Form";
            this.Text = "Party_Form";
            this.Load += new System.EventHandler(this.Party_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            this.guestLabel.ResumeLayout(false);
            this.guestLabel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.supplyLabel.ResumeLayout(false);
            this.supplyLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingNavigator)).EndInit();
            this.partiesBindingNavigator.ResumeLayout(false);
            this.partiesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel guestLabel;
        private System.Windows.Forms.Label guestsLabel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel supplyLabel;
        private System.Windows.Forms.Label suppliesLabel2;
        private System.Windows.Forms.Button partyReportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.Button addSupplyButton;
        private PartyDatabaseDataSet partyDatabaseDataSet;
        private System.Windows.Forms.BindingSource partiesBindingSource;
        private PartyDatabaseDataSetTableAdapters.PartiesTableAdapter partiesTableAdapter;
        private PartyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox party_NameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private PartyDatabaseDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton partiesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator partiesBindingNavigator;
        private System.Windows.Forms.ListBox guestListBox;
        private System.Windows.Forms.Button manageGuestButton;
        private System.Windows.Forms.ListBox ItemBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private PartyDatabaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox ItemTextBox;
        private PartyDatabaseDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter1;
        private System.Windows.Forms.Label itemLabel1;
        private System.Windows.Forms.Label last_NameLabel1;
        private System.Windows.Forms.Label first_NameLabel1;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button RemovePartyButton;
    }
}
