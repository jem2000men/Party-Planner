namespace Party_Planner_Application
{
    partial class openingForm
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
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.parttyListButton = new System.Windows.Forms.Button();
            this.addPartyButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPanel2 = new System.Windows.Forms.Panel();
            this.partyList = new System.Windows.Forms.ListBox();
            this.partyDatabaseDataSet = new Party_Planner_Application.PartyDatabaseDataSet();
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.PartiesTableAdapter();
            this.mainMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoScroll = true;
            this.mainMenuPanel.BackColor = System.Drawing.Color.Black;
            this.mainMenuPanel.Controls.Add(this.partyList);
            this.mainMenuPanel.Controls.Add(this.parttyListButton);
            this.mainMenuPanel.Controls.Add(this.addPartyButton);
            this.mainMenuPanel.Controls.Add(this.calendarButton);
            this.mainMenuPanel.Controls.Add(this.logoPanel);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(332, 863);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // parttyListButton
            // 
            this.parttyListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parttyListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parttyListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parttyListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttyListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.parttyListButton.Location = new System.Drawing.Point(0, 310);
            this.parttyListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parttyListButton.Name = "parttyListButton";
            this.parttyListButton.Size = new System.Drawing.Size(332, 78);
            this.parttyListButton.TabIndex = 3;
            this.parttyListButton.Text = "Party List";
            this.parttyListButton.UseVisualStyleBackColor = true;
            this.parttyListButton.Click += new System.EventHandler(this.parttyListButton_Click);
            // 
            // addPartyButton
            // 
            this.addPartyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPartyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPartyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPartyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPartyButton.Location = new System.Drawing.Point(0, 232);
            this.addPartyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPartyButton.Name = "addPartyButton";
            this.addPartyButton.Size = new System.Drawing.Size(332, 78);
            this.addPartyButton.TabIndex = 2;
            this.addPartyButton.Text = "Add Party";
            this.addPartyButton.UseVisualStyleBackColor = true;
            this.addPartyButton.Click += new System.EventHandler(this.addPartyButton_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calendarButton.Location = new System.Drawing.Point(0, 154);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(332, 78);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(332, 154);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Party_Planner_Application.Properties.Resources.LogoHat;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logoPanel2
            // 
            this.logoPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.logoPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel2.Location = new System.Drawing.Point(332, 0);
            this.logoPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPanel2.Name = "logoPanel2";
            this.logoPanel2.Size = new System.Drawing.Size(1069, 863);
            this.logoPanel2.TabIndex = 2;
            // 
            // partyList
            // 
            this.partyList.BackColor = System.Drawing.SystemColors.InfoText;
            this.partyList.DataSource = this.partiesBindingSource;
            this.partyList.DisplayMember = "Party Name";
            this.partyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.partyList.FormattingEnabled = true;
            this.partyList.ItemHeight = 29;
            this.partyList.Location = new System.Drawing.Point(3, 395);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(322, 236);
            this.partyList.TabIndex = 4;
            this.partyList.Visible = false;
            // 
            // partyDatabaseDataSet
            // 
            this.partyDatabaseDataSet.DataSetName = "PartyDatabaseDataSet";
            this.partyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partiesBindingSource
            // 
            this.partiesBindingSource.DataMember = "Parties";
            this.partiesBindingSource.DataSource = this.partyDatabaseDataSet;
            // 
            // partiesTableAdapter
            // 
            this.partiesTableAdapter.ClearBeforeFill = true;
            // 
            // openingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1401, 863);
            this.Controls.Add(this.logoPanel2);
            this.Controls.Add(this.mainMenuPanel);
            this.MinimumSize = new System.Drawing.Size(1414, 893);
            this.Name = "openingForm";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.openingForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button parttyListButton;
        private System.Windows.Forms.Button addPartyButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel logoPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox partyList;
        private PartyDatabaseDataSet partyDatabaseDataSet;
        private System.Windows.Forms.BindingSource partiesBindingSource;
        private PartyDatabaseDataSetTableAdapters.PartiesTableAdapter partiesTableAdapter;
    }
}
