using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;

namespace Tyuiu.MolokanovNK.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double product = 1.0;
            int realNumberCount = 0;

            string fileContent = File.ReadAllText(path);
            string[] numbers = fileContent.Split(new char[] { ' ', ',', '\t', '\n', '\r' },
                                        StringSplitOptions.RemoveEmptyEntries);

            

            foreach (string numberStr in numbers)
            {
                if (double.TryParse(numberStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    
                    if (Math.Abs(number % 1) > 0.000001) 
                    {
                        double oldProduct = product;
                        product *= number;
                        realNumberCount++;
                        
                    }
                    
                    
                       
                    
                }
            }

            
            return Math.Round(product, 3);

        }
    }
}
