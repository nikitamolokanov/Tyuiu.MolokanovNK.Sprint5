using Tyuiu.MolokanovNK.Sprint5.Task5.V4.Lib;
using System.IO;

namespace Tyuiu.MolokanovNK.Sprint5.Task5.V4.Test
{
    [TestClass]
    public sealed class DataService
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask5V4.txt ";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
