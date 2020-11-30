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
    public partial class ManageGuestForm : Form
    {
        int currentparty;
        int currentguest;
        public ManageGuestForm(int currentparty, int currentguest)
        { 
            InitializeComponent();
            this.currentparty = currentparty;
            this.currentguest = currentguest;
        }

        private void guestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.guestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);

        }

        private void ManageGuestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partyDatabaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Items, currentparty);

            this.guestsTableAdapter.FillByPartyAndGuest(this.partyDatabaseDataSet.Guests, currentparty, currentguest);

        }

        private void SaveAndExit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.guestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
            this.Close();
        }

        private void CancelAndExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearItemBtn_Click(object sender, EventArgs e)
        {
            itemComboBox.SelectedIndex = -1;
        }
    }
}
