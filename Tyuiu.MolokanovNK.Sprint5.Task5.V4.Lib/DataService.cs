using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolokanovNK.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на отдельные числа по пробелам
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    // Обрабатываем каждое число отдельно
                    foreach (string numberStr in numbers)
                    {
                        if (double.TryParse(numberStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                        {
                            res *= number;
                        }
                    }
                }
            }

            
            return Math.Round(res, 3);
        }
           

        
    }
}
