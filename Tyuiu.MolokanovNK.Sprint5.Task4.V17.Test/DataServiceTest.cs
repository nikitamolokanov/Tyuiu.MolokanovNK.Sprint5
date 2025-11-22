using Tyuiu.MolokanovNK.Sprint5.Task4.V17.Lib;
using System.IO;

namespace Tyuiu.MolokanovNK.Sprint5.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"С:\DataSprint5\InPutDataFileTask4V17.txt ";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
            
        }
    }
}
