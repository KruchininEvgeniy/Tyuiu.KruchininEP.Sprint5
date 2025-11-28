using Tyuiu.KruchininEP.Sprint5.Task7.V21.Lib;
using System.IO;
namespace Tyuiu.KruchininEP.Sprint5.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedExistFile()
        {
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task7.V21\bin\Debug\net8.0\OutPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}