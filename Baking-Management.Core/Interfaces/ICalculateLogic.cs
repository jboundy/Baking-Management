using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baking_Management.Core.Interfaces
{
    interface ICalculateLogic
    {
        string CalculateValues(ListView lvCalculate);
        List<ListViewItem> GetSelectedDataContents(ListView lvCollection);
        string GetSelectedDataContents(TreeView tvCollection);
    }
}
