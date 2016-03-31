using System;
using System.Windows.Forms;

namespace Baking_Management
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosing += Menu_FormClosing;
        }

        private void btnEntryForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntryForm form = new EntryForm();
            form.Show();
        }

        private void btnDataManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataManagment form = new DataManagment();
            form.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
