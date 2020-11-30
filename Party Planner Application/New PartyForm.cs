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
    public partial class New_PartyForm : Form
    {
        public New_PartyForm()
        {
            InitializeComponent();
        }

        private void AddPartyButton_Click(object sender, EventArgs e) //Adds party to database with specified values
        {
            if (party_NameTextBox.Text != "") //Ensures there is a party name
            {
                this.partiesTableAdapter.InsertParty(party_NameTextBox.Text, dateDateTimePicker.Value, locationTextBox.Text);
                this.Close();
            }
            else //if not ask user to add one
            {
                MessageBox.Show("Please enter a party name first!");
            }
        }

        private void New_PartyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
