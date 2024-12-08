using System.IO;
using Tyuiu.DemchenkoAD.Sprint5.Task3.V8.Lib;
namespace Tyuiu.DemchenkoAD.Sprint5.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = true;
            Assert.AreEqual(expect, fileexists);
        }
    }
}