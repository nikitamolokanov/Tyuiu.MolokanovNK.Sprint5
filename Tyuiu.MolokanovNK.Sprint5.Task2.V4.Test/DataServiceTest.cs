using System.IO;
using Tyuiu.MolokanovNK.Sprint5.Task2.V4.Lib;
namespace Tyuiu.MolokanovNK.Sprint5.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\yoLegacy\source\repos\Tyuiu.MolokanovNK.Sprint5\Tyuiu.MolokanovNK.Sprint5.Task2.V4\bin\Debug";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
