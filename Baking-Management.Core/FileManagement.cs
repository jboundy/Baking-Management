using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Baking_Management.Core.Models;
using System.Windows.Forms;
using Baking_Management.Core.Interfaces;

namespace Baking_Management.Core
{
    public class FileManagement : IFileManagement
    {
        public List<Baking> GetRowsFromFile()
        {
            List<Baking> list = new List<Baking>();
            string file = GetDataFile();

            using (new StreamReader(file))
            {
                var lines = File.ReadAllLines(file).Select(a => a.Split(','));
                list.AddRange(lines.Select(line => new Baking()
                {
                    Category = line[0],
                    Type = line[1],
                    Price = line[2]
                }));
            }

            return list;
        }
        public void WriteToFile(DataGridView dataGv)
        {
            string outputFile = GetDataFile();
            int count = 0;
            if (dataGv.Columns.Count != 0)
            {

                StringBuilder sb = new StringBuilder();

                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }

                StreamWriter sw = new StreamWriter(outputFile, true);

                // loop through each row of our DataGridView

                foreach (DataGridViewRow row in dataGv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            break;
                        }

                        switch (count)
                        {
                            default:
                                sb.Append(cell.Value + ",");
                                count++;
                                break;
                            case 1:
                                sb.Append(cell.Value);
                                count++;
                                break;
                            case 2:
                                sb.Append(Environment.NewLine);
                                count = 0;
                                goto default;
                        }
                    }
                }
                sw.WriteLine(sb.ToString());
                sw.Close();

                GC.Collect();
            }
        }

        private string GetDataFile()
        {
            var filePath = AppDomain.CurrentDomain.BaseDirectory;
            filePath = Directory.GetParent(filePath).FullName;
            string file = filePath + @"\FileStore\BakingStore.csv";
            return file;
        }
    }
}
