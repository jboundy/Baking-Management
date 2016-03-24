using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baking_Management.Core.Models;

namespace Baking_Management.Core.Interfaces
{
    interface IFileManagement
    {
        List<Baking> GetIngredientsFromFile();
        void WriteToFile(DataGridView dataGv);
    }
}
