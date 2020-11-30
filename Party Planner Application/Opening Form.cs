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
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);
            boldCalendarDates();
            UpdateCalList();
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
            UpdateCalList();
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
                boldCalendarDates();
                UpdateCalList();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Please pick a party first!");
            }
        }
        private void boldCalendarDates()
        {
            partyCalendar.RemoveAllBoldedDates();
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

        private void calendarButton_Click(object sender, EventArgs e)
        {
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
            UpdateCalList();
        }

        private void UpdateCalList()
        {
            partyBox.Items.Clear();
            datesListBox.SelectedIndex = -1;
            for (int i = 0; i < datesListBox.Items.Count; i++)
            {
                datesListBox.SelectedIndex += 1;
                try
                {
                    if (partyCalendar.SelectionRange.Start.ToString("d") == DateTime.Parse(datesListBox.SelectedValue.ToString()).ToString("d"))
                    {
                        datesListBox.ValueMember = "Party Name";
                        partyBox.Items.Add(datesListBox.SelectedValue.ToString());
                        datesListBox.ValueMember = "Date";

                    }
                }
                catch (System.NullReferenceException ex)
                {

                }
                catch (System.Exception ex)
                {

                }
            }
        }

    }
}
