using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolokanovNK.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = x / Math.Sqrt(Math.Pow(x, 2) + x);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
