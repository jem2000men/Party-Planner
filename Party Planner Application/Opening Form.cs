using System;
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
            //On load, fill parties and bold and fill calendar list
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
            boldCalendarDates();
            UpdateCalList();
        }

        private void calenderButton_Click(object sender, EventArgs e)
        {
          
        }

        private void addPartyButton_Click(object sender, EventArgs e)
        {
            // Open party form and save values
            New_PartyForm newPForm = new New_PartyForm();
            newPForm.ShowDialog();
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
            partyList.SelectedIndex = -1;
            boldCalendarDates(); //Update calendar bolded dates and claendar list
            UpdateCalList();
        }

        private void parttyListButton_Click(object sender, EventArgs e)
        { //Toggle party list
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
        { //Opens party form for chosen party from list
            try
            {
                Party_Form partyForm = new Party_Form(int.Parse(partyList.SelectedValue.ToString()));
                partyForm.ShowDialog();
                this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
                boldCalendarDates();
                UpdateCalList();
                partyList.SelectedIndex = -1;
            }
            catch (System.Exception ex) //Otherwise asks user to pick party
            {
                MessageBox.Show("Please pick a party first!");
            }
        }
        private void boldCalendarDates()
        {
            partyCalendar.RemoveAllBoldedDates(); //To bold dates first clear all bolded dates
            datesListBox.SelectedIndex = -1; //Go to beginning of dateslistBox which holds all dates for parties
            for (int i = 0; i < datesListBox.Items.Count; i++) //For each date, bold it
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
            partyCalendar.UpdateBoldedDates(); //Update the calendar to show bolded dates
        }

        private void calendarButton_Click(object sender, EventArgs e)
        { //Toggles calendar and party list box which shows parties for selected date
            if (partyCalendar.Visible == false)
            {
                partyCalendar.Visible = true;
                partyBox.Visible = true;
            }
            else
            {
                partyCalendar.Visible = false;
                partyBox.Visible = false ;
            }
        }

        private void partyCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateCalList(); //When date changed update parties list box below calendar
        }

        private void UpdateCalList()
        {
            partyBox.Items.Clear(); //Clear party list box below calendar
            datesListBox.SelectedIndex = -1; //Go to beggining
            for (int i = 0; i < datesListBox.Items.Count; i++)
            {
                datesListBox.SelectedIndex += 1; //Increment index
                try
                {
                    if (partyCalendar.SelectionRange.Start.ToString("d") == DateTime.Parse(datesListBox.SelectedValue.ToString()).ToString("d")) //Compare dates using short date format (Selected date and stored party dates)
                    {// if match, change calue member to party name, add to party list box, and change value member back to date for next comparison
                        datesListBox.ValueMember = "Party Name";
                        partyBox.Items.Add(datesListBox.SelectedValue.ToString());
                        datesListBox.ValueMember = "Date";

                    }
                }
                catch (System.NullReferenceException ex)
                {
                    //Catch if no date for specific party
                }
                catch (System.Exception ex)
                {
                    //Catch other exceptions
                }
            }
        }

    }
}
