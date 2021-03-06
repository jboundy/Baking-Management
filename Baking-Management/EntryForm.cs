﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Baking_Management.Core;

namespace Baking_Management
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            //LoadSource();
            LoadTreeView();
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

            //removed 5/12 - JB - this uses the listview on the form rather than treeview
            //List<ListViewItem> data = calculate.GetDataContents(lvSourceDataEntry);

            //foreach (var item in data)
            //{
            //    lvCalculationDataEntry.Items.Add(item.Text);
            //}

            string data = calculate.GetSelectedDataContents(tvSource);
            lvCalculationDataEntry.Items.Add(data);
            this.lvCalculationDataEntry.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            var calculate = new CalculateLogic();
            List<ListViewItem> data = calculate.GetSelectedDataContents(lvCalculationDataEntry);

            foreach (var item in data)
            {
                lvCalculationDataEntry.Items.Remove(item);
            }
        }

        private void btnGoToDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataManagment form = new DataManagment();
            form.Show();
        }

        private void LoadSource()
        {
            this.lvSourceDataEntry.Items.Clear();
            var file = new FileManagement();
            this.lvSourceDataEntry.View = View.Details;
            this.lvSourceDataEntry.Columns.Add("Type");
            this.lvSourceDataEntry.HeaderStyle = ColumnHeaderStyle.None;
            var rows = file.GetRowsFromFile();
            foreach (var row in rows)
            {
                lvSourceDataEntry.Items.Add(row.Type);
            }
            this.lvSourceDataEntry.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LoadDestination()
        {
            this.lvCalculationDataEntry.Items.Clear();
            this.lvCalculationDataEntry.View = View.Details;
            this.lvCalculationDataEntry.Columns.Add("Type");
            this.lvCalculationDataEntry.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void LoadTreeView()
        {
            var file = new FileManagement();
            Dictionary<string, int> indexes = new Dictionary<string, int>();
            int indexer = 0;
            var rows = file.GetRowsFromFile();
            foreach (var row in rows)
            {
                if (!indexes.ContainsKey(row.Category))
                {
                    tvSource.Nodes.Add(row.Category);
                    indexes.Add(row.Category, indexer);
                    indexer++;
                }
                int value = indexes[row.Category];
                tvSource.Nodes[value].Nodes.Add(row.Type);
            }
        }
    }
}
