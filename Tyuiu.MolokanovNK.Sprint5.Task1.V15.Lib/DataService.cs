using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolokanovNK.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double start = -5;
            double end = 5;
            double step = 1;
            string outputFile = "OutPutFileTask1.txt";

            File.WriteAllText(outputFile, "");

            

            for (double x = start; x <= end; x += step)
            {
                double result;

                if (Math.Abs(x - 0.4) < 0.000001)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2;
                }

                result = Math.Round(result, 2);
                File.AppendAllText(outputFile, $"{result}\n");
                
            }

            

        }
    }
}
