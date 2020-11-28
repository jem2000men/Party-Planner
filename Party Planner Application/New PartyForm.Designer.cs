namespace Party_Planner_Application
{
    partial class New_PartyForm
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
            this.party_NameTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.NewPartyLabel = new System.Windows.Forms.Label();
            this.AddPartyButton = new System.Windows.Forms.Button();
            this.partiesTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.PartiesTableAdapter();
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyDatabaseDataSet = new Party_Planner_Application.PartyDatabaseDataSet();
            this.partiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.TableAdapterManager();
            party_NameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // party_NameLabel
            // 
            party_NameLabel.AutoSize = true;
            party_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            party_NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            party_NameLabel.Location = new System.Drawing.Point(86, 160);
            party_NameLabel.Name = "party_NameLabel";
            party_NameLabel.Size = new System.Drawing.Size(144, 29);
            party_NameLabel.TabIndex = 18;
            party_NameLabel.Text = "Party Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dateLabel.Location = new System.Drawing.Point(86, 217);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(69, 29);
            dateLabel.TabIndex = 20;
            dateLabel.Text = "Date:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            locationLabel.Location = new System.Drawing.Point(86, 274);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(110, 29);
            locationLabel.TabIndex = 22;
            locationLabel.Text = "Location:";
            // 
            // party_NameTextBox
            // 
            this.party_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_NameTextBox.Location = new System.Drawing.Point(266, 157);
            this.party_NameTextBox.Name = "party_NameTextBox";
            this.party_NameTextBox.Size = new System.Drawing.Size(423, 35);
            this.party_NameTextBox.TabIndex = 19;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(266, 217);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(423, 35);
            this.dateDateTimePicker.TabIndex = 21;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(266, 274);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(423, 35);
            this.locationTextBox.TabIndex = 23;
            // 
            // NewPartyLabel
            // 
            this.NewPartyLabel.AutoSize = true;
            this.NewPartyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPartyLabel.Location = new System.Drawing.Point(167, 63);
            this.NewPartyLabel.Name = "NewPartyLabel";
            this.NewPartyLabel.Size = new System.Drawing.Size(451, 37);
            this.NewPartyLabel.TabIndex = 24;
            this.NewPartyLabel.Text = "Please Enter Party Information";
            // 
            // AddPartyButton
            // 
            this.AddPartyButton.Location = new System.Drawing.Point(392, 347);
            this.AddPartyButton.Name = "AddPartyButton";
            this.AddPartyButton.Size = new System.Drawing.Size(179, 57);
            this.AddPartyButton.TabIndex = 25;
            this.AddPartyButton.Text = "Add Party";
            this.AddPartyButton.UseVisualStyleBackColor = true;
            this.AddPartyButton.Click += new System.EventHandler(this.AddPartyButton_Click);
            // 
            // partiesTableAdapter
            // 
            this.partiesTableAdapter.ClearBeforeFill = true;
            // 
            // partiesBindingSource
            // 
            this.partiesBindingSource.DataMember = "Parties";
            // 
            // partyDatabaseDataSet
            // 
            this.partyDatabaseDataSet.DataSetName = "PartyDatabaseDataSet";
            this.partyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partiesBindingSource1
            // 
            this.partiesBindingSource1.DataMember = "Parties";
            this.partiesBindingSource1.DataSource = this.partyDatabaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GuestsTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.PartiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Party_Planner_Application.PartyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // New_PartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPartyButton);
            this.Controls.Add(this.NewPartyLabel);
            this.Controls.Add(party_NameLabel);
            this.Controls.Add(this.party_NameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Name = "New_PartyForm";
            this.Text = "New_PartyForm";
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox party_NameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label NewPartyLabel;
        private System.Windows.Forms.Button AddPartyButton;
        private PartyDatabaseDataSetTableAdapters.PartiesTableAdapter partiesTableAdapter;
        private System.Windows.Forms.BindingSource partiesBindingSource;
        private PartyDatabaseDataSet partyDatabaseDataSet;
        private System.Windows.Forms.BindingSource partiesBindingSource1;
        private PartyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}