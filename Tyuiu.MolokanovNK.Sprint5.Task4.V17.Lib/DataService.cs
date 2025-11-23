using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolokanovNK.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
           


            string strX = File.ReadAllText(path);
            // Указываем культуру с точкой как разделителем
            double x = Convert.ToDouble(strX, System.Globalization.CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);


            return res;
        }
    }
}
