using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;

namespace Tyuiu.MolokanovNK.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i <= line.Length - 5; i++)
                    {
                        if (char.IsDigit(line[i]) &&
                            char.IsDigit(line[i + 1]) &&
                            char.IsDigit(line[i + 2]) &&
                            char.IsDigit(line[i + 3]) &&
                            char.IsDigit(line[i + 4]))
                        {
                            bool leftBoundary = (i == 0) || !char.IsDigit(line[i - 1]);
                            bool rightBoundary = (i + 5 >= line.Length) || !char.IsDigit(line[i + 5]);

                            if (leftBoundary && rightBoundary)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
