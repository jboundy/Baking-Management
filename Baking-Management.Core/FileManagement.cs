using System.Collections.Generic;
using System.IO;
using System.Linq;
using Baking_Management.Core.Models;
using System.Windows.Forms;
using Baking_Management.Core.Interfaces;

namespace Baking_Management.Core
{
    public class FileManagement : IFileManagement
    {
        public List<Baking> GetIngredientsFromFile()
        {
            var list = new List<Baking>();
            var path = "D:/Source/Repos/Baking-Management/Baking-Management.Core/DataStore/BakingStore.csv";
            var reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var lines = File.ReadAllLines(path).Select(a => a.Split(','));
                list.AddRange(lines.Select(line => new Baking()
                {
                    Ingredient = line[0], Price = line[1]
                }));
                
            }

            return list;
        }

        public void WriteToFile(DataGridView dataGv)
        {
            var path = "";
            var writer = new StreamWriter(path);
            var data = dataGv.DataSource;
            for (int i = 0; i < dataGv.Columns.Count; i++)
            {
                writer.Write(dataGv.Columns[i].HeaderText);
                if (i != dataGv.Columns.Count)
                {
                    writer.Write(",");
                }
            }

            writer.Write(writer.NewLine);

            foreach (DataGridViewRow gridVR in dataGv.Rows)
            {
                for (int i = 0; i < dataGv.Columns.Count; i++)
                {
                    writer.Write(gridVR.Cells[i].Value);
                    if (i != dataGv.Columns.Count)
                    {
                        writer.Write(",");
                    }
                }
                writer.Write(writer.NewLine);
            }

            writer.Flush();
            writer.Close();
        }
    }
}
