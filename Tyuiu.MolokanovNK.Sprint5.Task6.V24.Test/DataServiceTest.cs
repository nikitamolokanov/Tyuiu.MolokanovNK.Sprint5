using Tyuiu.MolokanovNK.Sprint5.Task6.V24.Lib;
using System.IO;

namespace Tyuiu.MolokanovNK.Sprint5.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"С:\DataSprint5\InPutDataFileTask6V24.txt ";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask6V24.txt ";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
