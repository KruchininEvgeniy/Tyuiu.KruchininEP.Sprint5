using System.IO;
using Tyuiu.KruchininEP.Sprint5.Task3.V24.Lib;
namespace Tyuiu.KruchininEP.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string paths = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task3.V24\bin\Debug\net8.0\OutPutFileTask3.txt";
            string fullPath = Path.Combine(paths);
            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}