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
        int currentparty; //int to represent partyId
        int currentguest; //int to represent GuestId
        public ManageGuestForm(int currentparty, int currentguest)
        { 
            InitializeComponent();
            this.currentparty = currentparty; //Sets attributes
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
            // Fill Items combo box and guest info by partyId and guestId
            this.itemsTableAdapter.FillByPartyId(this.partyDatabaseDataSet.Items, currentparty);

            this.guestsTableAdapter.FillByPartyAndGuest(this.partyDatabaseDataSet.Guests, currentparty, currentguest);

        }

        private void SaveAndExit_Click(object sender, EventArgs e) //Applies changes to database
        {
            this.Validate();
            this.guestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
            this.Close(); //and closes form
        }

        private void CancelAndExit_Click(object sender, EventArgs e) //Closes form without applying changes
        {
            this.Close();
        }

        private void ClearItemBtn_Click(object sender, EventArgs e)
        {
            itemComboBox.Text = ""; //Clears item selected
        }

        private void uninviteButton_Click(object sender, EventArgs e) //Uninvites guest
        {
            try
            {
                this.guestsTableAdapter.DeleteGuest(currentguest, currentparty);

                this.Validate();
                this.guestsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
                this.Close();
            }
            catch (System.Exception ex) //Sometimes error occurs when item changed before uninviting, this addresses issue
            {
                this.Close();
            }
        }
    }
}
