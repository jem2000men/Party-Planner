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
        public Party_Form()
        {
            InitializeComponent();
        }

        private void partiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);

        }

        private void Party_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partyDatabaseDataSet.Parties' table. You can move, or remove it, as needed.
            this.partiesTableAdapter.Fill(this.partyDatabaseDataSet.Parties);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.partyDatabaseDataSet);
        }
    }
}
