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

        private void AddPartyButton_Click(object sender, EventArgs e)
        {
            this.partiesTableAdapter.InsertParty(party_NameTextBox.Text, dateDateTimePicker.Value, locationTextBox.Text);
            this.Close();
        }
    }
}
