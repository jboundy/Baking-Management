using System.Collections.Generic;
using System.Windows.Forms;
using Baking_Management.Core.Models;

namespace Baking_Management.Core.Interfaces
{
    interface IFileManagement
    {
        List<Baking> GetRowsFromFile();
        void WriteToFile(DataGridView dataGv);
    }
}
