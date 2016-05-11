using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Baking_Management.Core;

namespace Baking_Management
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            LoadSource();
            LoadDestination();
            this.FormClosing += EntryForm_FormClosing;
        }

        private void CalculateDataEntry_Click(object sender, EventArgs e)
        {
            var calculate = new CalculateLogic();
            var total = calculate.CalculateValues(lvCalculationDataEntry);
            tbTotal.Text = @"$" + total;
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
            var calculate = new CalculateLogic();
            List<ListViewItem> data = calculate.GetDataContents(lvSourceDataEntry);

            foreach (var item in data)
            {
                lvCalculationDataEntry.Items.Add(item.Text);
            }
            this.lvCalculationDataEntry.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            var calculate = new CalculateLogic();
            List<ListViewItem> data = calculate.GetDataContents(lvCalculationDataEntry);

            foreach (var item in data)
            {
                lvCalculationDataEntry.Items.Remove(item);
            }
        }

        public void LoadSource()
        {
            this.lvSourceDataEntry.Items.Clear();
            var file = new FileManagement();
            this.lvSourceDataEntry.View = View.Details;
            this.lvSourceDataEntry.Columns.Add("Type");
            this.lvSourceDataEntry.HeaderStyle = ColumnHeaderStyle.None;
            var rows = file.GetTypesFromFile();
            foreach (var row in rows)
            {
                lvSourceDataEntry.Items.Add(row.Type);
            }
            this.lvSourceDataEntry.AutoResizeColumn(0,ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void LoadDestination()
        {
            this.lvCalculationDataEntry.Items.Clear();
            this.lvCalculationDataEntry.View = View.Details;
            this.lvCalculationDataEntry.Columns.Add("Type");
            this.lvCalculationDataEntry.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void btnGoToDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataManagment form = new DataManagment();
            form.Show();
        }
    }
}
