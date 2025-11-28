using Tyuiu.KruchininEP.Sprint5.Task2.V16.Lib;


namespace Tyuiu.BurdovKS.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task2.V16\bin\Debug\net8.0\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}