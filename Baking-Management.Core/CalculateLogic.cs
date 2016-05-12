using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Baking_Management.Core.Interfaces;

namespace Baking_Management.Core
{
    public class CalculateLogic : ICalculateLogic
    {

        public string CalculateValues(ListView lvCalculate)
        {
            decimal total;
            FileManagement file = new FileManagement();
            var types = file.GetRowsFromFile();
            var contents = GetAllDataContents(lvCalculate);
            List<decimal> calculateThis = new List<decimal>();

            foreach (var type in types)
            {
                foreach (var content in contents)
                {
                    if (type.Type == content.Text)
                    {
                        calculateThis.Add(Convert.ToDecimal(type.Price));
                    }
                }
            }

            total = calculateThis.Sum();

            return Convert.ToString(total, CultureInfo.CurrentCulture);
        }

        public List<ListViewItem> GetSelectedDataContents(ListView lvCollection)
        {
            var items = lvCollection.SelectedItems;
            var count = lvCollection.SelectedItems.Count;

            List<ListViewItem> data = new List<ListViewItem>();
            for (int i = 0; i < count; i++)
            {
                data.Add(items[i]);
            }

            return data;
        }

        public string GetSelectedDataContents(TreeView tvCollection)
        {
            var data = tvCollection.SelectedNode;

            return data.Text;
        }

        private List<ListViewItem> GetAllDataContents(ListView lvCollection)
        {
            var items = lvCollection.Items;
            var count = lvCollection.Items.Count;

            List<ListViewItem> data = new List<ListViewItem>();
            for (int i = 0; i < count; i++)
            {
                data.Add(items[i]);
            }

            return data;
        }
    }
}
