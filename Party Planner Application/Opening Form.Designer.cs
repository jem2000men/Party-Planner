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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.partyBox = new System.Windows.Forms.ListBox();
            this.addPartyButton = new System.Windows.Forms.Button();
            this.calenderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.partyBox);
            this.splitContainer1.Panel1.Controls.Add(this.addPartyButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calenderButton);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 634);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // partyBox
            // 
            this.partyBox.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyBox.FormattingEnabled = true;
            this.partyBox.HorizontalScrollbar = true;
            this.partyBox.ItemHeight = 46;
            this.partyBox.Location = new System.Drawing.Point(0, 108);
            this.partyBox.Name = "partyBox";
            this.partyBox.Size = new System.Drawing.Size(336, 602);
            this.partyBox.TabIndex = 1;
            // 
            // addPartyButton
            // 
            this.addPartyButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartyButton.Location = new System.Drawing.Point(0, 9);
            this.addPartyButton.Name = "addPartyButton";
            this.addPartyButton.Size = new System.Drawing.Size(336, 93);
            this.addPartyButton.TabIndex = 0;
            this.addPartyButton.Text = "Add Party";
            this.addPartyButton.UseVisualStyleBackColor = true;
            // 
            // calenderButton
            // 
            this.calenderButton.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderButton.Location = new System.Drawing.Point(260, 190);
            this.calenderButton.Name = "calenderButton";
            this.calenderButton.Size = new System.Drawing.Size(162, 72);
            this.calenderButton.TabIndex = 0;
            this.calenderButton.Text = "Check Calender";
            this.calenderButton.UseVisualStyleBackColor = true;
            this.calenderButton.Click += new System.EventHandler(this.calenderButton_Click);
            // 
            // openingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1010, 634);
            this.Controls.Add(this.splitContainer1);
            this.Name = "openingForm";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.openingForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addPartyButton;
        private System.Windows.Forms.ListBox partyBox;
        private System.Windows.Forms.Button calenderButton;
    }
}

