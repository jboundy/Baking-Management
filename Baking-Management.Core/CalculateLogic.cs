using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baking_Management.Core.Interfaces;

namespace Baking_Management.Core
{
    public class CalculateLogic : ICalculateLogic
    {
        private FileManagement _fileManagement;
        public string CalculateValues(ListView lvCalculate)
        {
            string total = "";
            var file = _fileManagement;
            var types = file.GetTypesFromFile();
            foreach (var item in lvCalculate.Items)
            {
                
            }

            return total;
        }
    }
}
