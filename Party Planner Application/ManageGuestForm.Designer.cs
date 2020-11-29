namespace Party_Planner_Application
{
    partial class ManageGuestForm
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label itemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGuestForm));
            this.partyDatabaseDataSet = new Party_Planner_Application.PartyDatabaseDataSet();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.GuestsTableAdapter();
            this.tableAdapterManager = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.SaveAndExit = new System.Windows.Forms.Button();
            this.CancelAndExit = new System.Windows.Forms.Button();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.ItemsTableAdapter();
            this.ClearItemBtn = new System.Windows.Forms.Button();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(56, 48);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(137, 29);
            first_NameLabel.TabIndex = 1;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.Location = new System.Drawing.Point(56, 90);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(134, 29);
            last_NameLabel.TabIndex = 3;
            last_NameLabel.Text = "Last Name:";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemLabel.Location = new System.Drawing.Point(59, 139);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(65, 29);
            itemLabel.TabIndex = 8;
            itemLabel.Text = "Item:";
            // 
            // partyDatabaseDataSet
            // 
            this.partyDatabaseDataSet.DataSetName = "PartyDatabaseDataSet";
            this.partyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.partyDatabaseDataSet;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GuestsTableAdapter = this.guestsTableAdapter;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.PartiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Party_Planner_Application.PartyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "First Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameTextBox.Location = new System.Drawing.Point(193, 45);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(277, 35);
            this.first_NameTextBox.TabIndex = 2;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "Last Name", true));
            this.last_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameTextBox.Location = new System.Drawing.Point(193, 87);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(277, 35);
            this.last_NameTextBox.TabIndex = 4;
            // 
            // SaveAndExit
            // 
            this.SaveAndExit.Location = new System.Drawing.Point(96, 204);
            this.SaveAndExit.Name = "SaveAndExit";
            this.SaveAndExit.Size = new System.Drawing.Size(153, 52);
            this.SaveAndExit.TabIndex = 7;
            this.SaveAndExit.Text = "Save and Exit";
            this.SaveAndExit.UseVisualStyleBackColor = true;
            this.SaveAndExit.Click += new System.EventHandler(this.SaveAndExit_Click);
            // 
            // CancelAndExit
            // 
            this.CancelAndExit.Location = new System.Drawing.Point(276, 204);
            this.CancelAndExit.Name = "CancelAndExit";
            this.CancelAndExit.Size = new System.Drawing.Size(153, 52);
            this.CancelAndExit.TabIndex = 8;
            this.CancelAndExit.Text = "Cancel and Exit";
            this.CancelAndExit.UseVisualStyleBackColor = true;
            this.CancelAndExit.Click += new System.EventHandler(this.CancelAndExit_Click);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "Item", true));
            this.itemComboBox.DataSource = this.itemsBindingSource;
            this.itemComboBox.DisplayMember = "Item Name";
            this.itemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(193, 139);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(277, 37);
            this.itemComboBox.TabIndex = 9;
            this.itemComboBox.ValueMember = "Item Name";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.partyDatabaseDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // ClearItemBtn
            // 
            this.ClearItemBtn.Location = new System.Drawing.Point(489, 139);
            this.ClearItemBtn.Name = "ClearItemBtn";
            this.ClearItemBtn.Size = new System.Drawing.Size(162, 36);
            this.ClearItemBtn.TabIndex = 10;
            this.ClearItemBtn.Text = "Clear Item";
            this.ClearItemBtn.UseVisualStyleBackColor = true;
            this.ClearItemBtn.Click += new System.EventHandler(this.ClearItemBtn_Click);
            // 
            // ManageGuestForm
            // 
            this.AcceptButton = this.SaveAndExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 276);
            this.Controls.Add(this.ClearItemBtn);
            this.Controls.Add(itemLabel);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.CancelAndExit);
            this.Controls.Add(this.SaveAndExit);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageGuestForm";
            this.Text = "Manage Guest";
            this.Load += new System.EventHandler(this.ManageGuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PartyDatabaseDataSet partyDatabaseDataSet;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private PartyDatabaseDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
        private PartyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.Button SaveAndExit;
        private System.Windows.Forms.Button CancelAndExit;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private PartyDatabaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button ClearItemBtn;
    }
}