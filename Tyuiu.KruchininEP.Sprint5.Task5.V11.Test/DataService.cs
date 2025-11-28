using Tyuiu.KruchininEP.Sprint5.Task5.V11.Lib;
namespace Tyuiu.KruchininEP.Sprint5.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task5.V11\bin\Debug\net8.0\OutPutFileTask5.txt";
            string tempPath = Path.GetTempPath();


            string fileName = "OutOutFileTask0.txt";
            string p = Path.Combine(tempPath, fileName);

            FileInfo fileInfo = new FileInfo(path);


            bool fileExists = fileInfo.Exists;


            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}