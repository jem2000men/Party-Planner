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
    public partial class Party_Form : Form
    {
        int currentparty;
        public Party_Form(int currentparty)
        {
            InitializeComponent();
            this.currentparty = currentparty;
        }

        private void partiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);

        }

        private void Party_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partyDatabaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Items, currentparty);
            // TODO: This line of code loads data into the 'partyDatabaseDataSet.Guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Guests, currentparty);
            // TODO: This line of code loads data into the 'partyDatabaseDataSet.Parties' table. You can move, or remove it, as needed.
            this.partiesTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Parties, currentparty);


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.partiesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update Failed. Please try again...");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.partiesTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Parties, currentparty);
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            NewGuestForm newForm = new NewGuestForm(currentparty);
            newForm.ShowDialog();
            this.guestsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Guests, currentparty);
            this.Validate();
            this.guestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
        }

        private void manageGuestButton_Click(object sender, EventArgs e)
        {
            ManageGuestForm mgForm = new ManageGuestForm(currentparty, int.Parse(guestListBox.SelectedValue.ToString()));
            mgForm.ShowDialog();
            this.guestsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Guests, currentparty);
            this.Validate();
            this.guestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
        }

        private void addSupplyButton_Click(object sender, EventArgs e)
        {
            ItemTextBox.Visible = true;
            AddItemButton.Visible = true;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (ItemTextBox.Text != "")
            {
                this.itemsTableAdapter.InsertItem(-1, ItemTextBox.Text, currentparty);
                this.itemsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Items, currentparty);
                this.Validate();
                this.itemsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
                ItemTextBox.Text = "";
                
            }
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
        }
    }
}
