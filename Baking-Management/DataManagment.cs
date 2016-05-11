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
            gvDataManagement.ColumnCount = 3;
            gvDataManagement.ColumnHeadersVisible = true;
            gvDataManagement.Columns[0].Name = "Category";
            gvDataManagement.Columns[1].Name = "Type";
            gvDataManagement.Columns[2].Name = "Price";
            var rows = file.GetRowsFromFile();
            foreach (var row in rows)
            {
                gvDataManagement.Rows.Add(row.Category, row.Type, row.Price);
            }
            gvDataManagement.AutoResizeColumns();
        }
    }
}
