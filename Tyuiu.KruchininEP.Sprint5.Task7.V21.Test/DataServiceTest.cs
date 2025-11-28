using Tyuiu.KruchininEP.Sprint5.Task7.V21.Lib;
using System.IO;
namespace Tyuiu.KruchininEP.Sprint5.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\HASEE\Desktop\ТИУ\DataSprint5\InPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }

        [TestMethod]
        public void CheckedExistsOutPutFile()
        {
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task7.V21\bin\Debug\net8.0\OutPutDataFileTask7V21.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            Assert.AreEqual(true, fileexists);
        }
    }
}