using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolokanovNK.Sprint5.Task3.V7.Lib
{
    public class DataService : ISprint5Task3V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double z = 1.6 * Math.Pow(  x, 3) - 2.1 * Math.Pow( x, 2) +  7 * x;
            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
