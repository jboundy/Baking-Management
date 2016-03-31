using System;
using System.Windows.Forms;
using Baking_Management.Core;

namespace Baking_Management
{
    public partial class DataManagment : Form
    {
        public DataManagment()
        {
            InitializeComponent();
            LoadData();
            this.FormClosing += DataManagement_FormClosing;
        }

        private void btnDataSave_Click(object sender, EventArgs e)
        {
           var file = new FileManagement();
           file.WriteToFile(gvDataManagement);
        }

        private void btnDataCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void btnFormOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntryForm form = new EntryForm();
            form.Show();
        }

        private void DataManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void LoadData()
        {
            var file = new FileManagement();
            gvDataManagement.ColumnCount = 2;
            gvDataManagement.ColumnHeadersVisible = true;
            gvDataManagement.Columns[0].Name = "Type";
            gvDataManagement.Columns[1].Name = "Price";
            var rows = file.GetTypesFromFile();
            foreach (var row in rows)
            {
                gvDataManagement.Rows.Add(row.Type, row.Price);
            }       
        }
    }
}
