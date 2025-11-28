using Tyuiu.KruchininEP.Sprint5.Task6.V2.Lib;

namespace Tyuiu.KruchininEP.Sprint5.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task6.V2\bin\Debug\net8.0\OutPutFileTask6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\HASEE\source\repos\Tyuiu.KruchininEP.Sprint5\Tyuiu.KruchininEP.Sprint5.Task6.V2\bin\Debug\net8.0\OutPutFileTask6.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}