using System.Diagnostics;
using System.IO;
using Tyuiu.DemchenkoAD.Sprint5.Task1.V2.Lib;
namespace Tyuiu.DemchenkoAD.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C: \Users\12\source\repos\Tyuiu.DemchenkoAD.Sprint5\Tyuiu.DemchenkoAD.Sprint5.Task1.V2\bin\Debug\net8.0";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}