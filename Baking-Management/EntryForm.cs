using System;
using System.Windows.Forms;

namespace Baking_Management
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            LoadSource();
            this.FormClosing += EntryForm_FormClosing;
        }

        private void SaveDataEntry_Click(object sender, EventArgs e)
        {

        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelDataEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {

        }

        public void LoadSource()
        {
           lvSourceDataEntry.Items.Add()
        }
    }
}
