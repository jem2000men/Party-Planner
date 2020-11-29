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
    public partial class NewGuestForm : Form
    {
        int currentParty;
        public NewGuestForm(int currentParty)
        {
            InitializeComponent();
            this.currentParty = currentParty;
        }

        private void NewGuestForm_Load(object sender, EventArgs e)
        {

        }

        private void inviteGuestButton_Click(object sender, EventArgs e)
        {
            this.guestsTableAdapter.InsertGuest(currentParty, firstNameTextBox.Text, lastNameTextBox.Text, null);
            this.Close();
        }
    }
}
