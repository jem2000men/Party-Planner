﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner_Application
{
    public partial class openingForm : Form
    {
        public openingForm()
        {
            InitializeComponent();
        }

        private void openingForm_Load(object sender, EventArgs e)
        {
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
            boldCalendarDates();
        }

        private void calenderButton_Click(object sender, EventArgs e)
        {
          
        }

        private void addPartyButton_Click(object sender, EventArgs e)
        {
            New_PartyForm newPForm = new New_PartyForm();
            newPForm.ShowDialog();
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
            partyList.SelectedIndex = -1;
            boldCalendarDates();
        }

        private void parttyListButton_Click(object sender, EventArgs e)
        {
            if (partyList.Visible == false)
            {
                partyList.SelectedIndex = -1;
                partyList.Visible = true;
                openPartybutton.Visible = true;
            }
            else
            {
                partyList.Visible = false;
                openPartybutton.Visible = false;
            }
        }


        private void openPartybutton_Click(object sender, EventArgs e)
        {
            try
            {
                Party_Form partyForm = new Party_Form(int.Parse(partyList.SelectedValue.ToString()));
                partyForm.ShowDialog();
                this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Please pick a party first!");
            }
        }
        private void boldCalendarDates()
        {
            datesListBox.SelectedIndex = -1;
            for (int i = 0; i < datesListBox.Items.Count; i++)
            {
                try
                {
                    datesListBox.SelectedIndex += 1;
                    partyCalendar.AddBoldedDate(DateTime.Parse(datesListBox.SelectedValue.ToString()));
                    partyCalendar.UpdateBoldedDates();
                }
                catch(System.Exception ex)
                {

                }
            }
            partyCalendar.UpdateBoldedDates();
        }
    }
}
