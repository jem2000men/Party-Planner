﻿namespace Party_Planner_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openingForm));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.openPartybutton = new System.Windows.Forms.Button();
            this.partyList = new System.Windows.Forms.ListBox();
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyDatabaseDataSet = new Party_Planner_Application.PartyDatabaseDataSet();
            this.parttyListButton = new System.Windows.Forms.Button();
            this.addPartyButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPanel2 = new System.Windows.Forms.Panel();
            this.partyCalendar = new System.Windows.Forms.MonthCalendar();
            this.partyBox = new System.Windows.Forms.ListBox();
            this.datesListBox = new System.Windows.Forms.ListBox();
            this.partiesTableAdapter = new Party_Planner_Application.PartyDatabaseDataSetTableAdapters.PartiesTableAdapter();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logoPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoScroll = true;
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenuPanel.Controls.Add(this.openPartybutton);
            this.mainMenuPanel.Controls.Add(this.partyList);
            this.mainMenuPanel.Controls.Add(this.parttyListButton);
            this.mainMenuPanel.Controls.Add(this.addPartyButton);
            this.mainMenuPanel.Controls.Add(this.calendarButton);
            this.mainMenuPanel.Controls.Add(this.logoPanel);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(332, 702);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // openPartybutton
            // 
            this.openPartybutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openPartybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPartybutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openPartybutton.Location = new System.Drawing.Point(3, 628);
            this.openPartybutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openPartybutton.Name = "openPartybutton";
            this.openPartybutton.Size = new System.Drawing.Size(322, 52);
            this.openPartybutton.TabIndex = 5;
            this.openPartybutton.Text = "Open Party";
            this.openPartybutton.UseVisualStyleBackColor = true;
            this.openPartybutton.Visible = false;
            this.openPartybutton.Click += new System.EventHandler(this.openPartybutton_Click);
            // 
            // partyList
            // 
            this.partyList.BackColor = System.Drawing.SystemColors.Control;
            this.partyList.DataSource = this.partiesBindingSource;
            this.partyList.DisplayMember = "Party Name";
            this.partyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partyList.FormattingEnabled = true;
            this.partyList.ItemHeight = 29;
            this.partyList.Location = new System.Drawing.Point(3, 395);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(322, 207);
            this.partyList.TabIndex = 4;
            this.partyList.ValueMember = "PartyId";
            this.partyList.Visible = false;
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
            // parttyListButton
            // 
            this.parttyListButton.BackColor = System.Drawing.SystemColors.Control;
            this.parttyListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parttyListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parttyListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttyListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parttyListButton.Location = new System.Drawing.Point(0, 310);
            this.parttyListButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parttyListButton.Name = "parttyListButton";
            this.parttyListButton.Size = new System.Drawing.Size(332, 78);
            this.parttyListButton.TabIndex = 3;
            this.parttyListButton.Text = "Party List";
            this.parttyListButton.UseVisualStyleBackColor = false;
            this.parttyListButton.Click += new System.EventHandler(this.parttyListButton_Click);
            // 
            // addPartyButton
            // 
            this.addPartyButton.BackColor = System.Drawing.SystemColors.Control;
            this.addPartyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPartyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPartyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPartyButton.Location = new System.Drawing.Point(0, 232);
            this.addPartyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPartyButton.Name = "addPartyButton";
            this.addPartyButton.Size = new System.Drawing.Size(332, 78);
            this.addPartyButton.TabIndex = 2;
            this.addPartyButton.Text = "Add Party";
            this.addPartyButton.UseVisualStyleBackColor = false;
            this.addPartyButton.Click += new System.EventHandler(this.addPartyButton_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.SystemColors.Control;
            this.calendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calendarButton.Location = new System.Drawing.Point(0, 154);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(332, 78);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = false;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Aqua;
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
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
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
            this.logoPanel2.BackColor = System.Drawing.SystemColors.Menu;
            this.logoPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel2.Controls.Add(this.partyCalendar);
            this.logoPanel2.Controls.Add(this.partyBox);
            this.logoPanel2.Controls.Add(this.datesListBox);
            this.logoPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel2.Location = new System.Drawing.Point(332, 0);
            this.logoPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPanel2.Name = "logoPanel2";
            this.logoPanel2.Size = new System.Drawing.Size(646, 702);
            this.logoPanel2.TabIndex = 2;
            // 
            // partyCalendar
            // 
            this.partyCalendar.Location = new System.Drawing.Point(173, 107);
            this.partyCalendar.MaxSelectionCount = 1;
            this.partyCalendar.MinimumSize = new System.Drawing.Size(1, 2);
            this.partyCalendar.Name = "partyCalendar";
            this.partyCalendar.ShowTodayCircle = false;
            this.partyCalendar.TabIndex = 4;
            this.partyCalendar.Visible = false;
            this.partyCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.partyCalendar_DateChanged);
            // 
            // partyBox
            // 
            this.partyBox.BackColor = System.Drawing.SystemColors.Control;
            this.partyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyBox.FormattingEnabled = true;
            this.partyBox.ItemHeight = 25;
            this.partyBox.Location = new System.Drawing.Point(173, 372);
            this.partyBox.Name = "partyBox";
            this.partyBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.partyBox.Size = new System.Drawing.Size(312, 275);
            this.partyBox.TabIndex = 3;
            this.partyBox.ValueMember = "Date";
            this.partyBox.Visible = false;
            // 
            // datesListBox
            // 
            this.datesListBox.DataSource = this.partiesBindingSource;
            this.datesListBox.FormattingEnabled = true;
            this.datesListBox.ItemHeight = 20;
            this.datesListBox.Location = new System.Drawing.Point(9, 118);
            this.datesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datesListBox.Name = "datesListBox";
            this.datesListBox.Size = new System.Drawing.Size(128, 144);
            this.datesListBox.TabIndex = 2;
            this.datesListBox.ValueMember = "Date";
            this.datesListBox.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(978, 702);
            this.Controls.Add(this.logoPanel2);
            this.Controls.Add(this.mainMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 668);
            this.Name = "openingForm";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.openingForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyDatabaseDataSet)).EndInit();
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logoPanel2.ResumeLayout(false);
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
        private PartyDatabaseDataSet partyDatabaseDataSet;
        private System.Windows.Forms.BindingSource partiesBindingSource;
        private PartyDatabaseDataSetTableAdapters.PartiesTableAdapter partiesTableAdapter;
        private System.Windows.Forms.Button openPartybutton;
        private System.Windows.Forms.ListBox partyList;
        private System.Windows.Forms.ListBox datesListBox;
        private System.Windows.Forms.ListBox partyBox;
        private System.Windows.Forms.MonthCalendar partyCalendar;
    }
}
