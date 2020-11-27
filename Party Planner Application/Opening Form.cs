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
            // TODO: This line of code loads data into the 'partyDatabaseDataSet.Parties' table. You can move, or remove it, as needed.
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);

        }

        private void calenderButton_Click(object sender, EventArgs e)
        {
          
        }

        private void addPartyButton_Click(object sender, EventArgs e)
        {
            Party_Form partyForm = new Party_Form();
            partyForm.ShowDialog();

        }

        private void parttyListButton_Click(object sender, EventArgs e)
        {
            if (partyList.Visible == false)
                partyList.Visible = true;
            else
                partyList.Visible = false;
        }
    }
}
