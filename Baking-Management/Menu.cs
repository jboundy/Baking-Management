using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baking_Management
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
    }
}
