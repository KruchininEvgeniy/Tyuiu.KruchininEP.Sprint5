using Tyuiu.KruchininEP.Sprint5.Task4.V28.Lib;

namespace Tyuiu.KruchininEP.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task4.V28\bin\Debug\net8.0\OutPutFileTask4.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}