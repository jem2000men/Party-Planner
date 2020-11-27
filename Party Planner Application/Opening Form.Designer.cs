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
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.parttyListButton = new System.Windows.Forms.Button();
            this.addPartyButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPanel2 = new System.Windows.Forms.Panel();
            this.mainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoScroll = true;
            this.mainMenuPanel.BackColor = System.Drawing.Color.Black;
            this.mainMenuPanel.Controls.Add(this.parttyListButton);
            this.mainMenuPanel.Controls.Add(this.addPartyButton);
            this.mainMenuPanel.Controls.Add(this.calendarButton);
            this.mainMenuPanel.Controls.Add(this.logoPanel);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(221, 561);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // parttyListButton
            // 
            this.parttyListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parttyListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parttyListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parttyListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parttyListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.parttyListButton.Location = new System.Drawing.Point(0, 202);
            this.parttyListButton.Name = "parttyListButton";
            this.parttyListButton.Size = new System.Drawing.Size(221, 51);
            this.parttyListButton.TabIndex = 3;
            this.parttyListButton.Text = "Party List";
            this.parttyListButton.UseVisualStyleBackColor = true;
            // 
            // addPartyButton
            // 
            this.addPartyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPartyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPartyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPartyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPartyButton.Location = new System.Drawing.Point(0, 151);
            this.addPartyButton.Name = "addPartyButton";
            this.addPartyButton.Size = new System.Drawing.Size(221, 51);
            this.addPartyButton.TabIndex = 2;
            this.addPartyButton.Text = "Add Party";
            this.addPartyButton.UseVisualStyleBackColor = true;
            // 
            // calendarButton
            // 
            this.calendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calendarButton.Location = new System.Drawing.Point(0, 100);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(221, 51);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::Party_Planner_Application.Properties.Resources.LogoHat;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(221, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPanel2
            // 
            this.logoPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.logoPanel2.BackgroundImage = global::Party_Planner_Application.Properties.Resources.LogoHat2;
            this.logoPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel2.Location = new System.Drawing.Point(221, 0);
            this.logoPanel2.Name = "logoPanel2";
            this.logoPanel2.Size = new System.Drawing.Size(713, 561);
            this.logoPanel2.TabIndex = 2;
            // 
            // openingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.logoPanel2);
            this.Controls.Add(this.mainMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "openingForm";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.openingForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button parttyListButton;
        private System.Windows.Forms.Button addPartyButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel logoPanel2;
    }
}
