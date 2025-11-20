using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolokanovNK.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }


            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            
            string csvContent = "";
            for (int i = 0; i < rows; i++)
            {
                string rowStr = "";
                for (int j = 0; j < cols; j++)
                {
                    rowStr += matrix[i, j].ToString();
                    if (j < cols - 1)
                    {
                        rowStr += ";";
                    }
                }

                csvContent += rowStr;
                if (i < rows - 1)
                {
                    csvContent += Environment.NewLine;
                }
            }

            
            File.AppendAllText(path, csvContent);

            
            

            return path;


        }
    }
}
