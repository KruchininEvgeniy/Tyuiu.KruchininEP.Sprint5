using System.Diagnostics;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KruchininEP.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path) 
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V21.txt");

            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileexist = fileinfo.Exists;
            if (fileexist)
            {
                File.Delete(pathSaveFile);
            }

            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != '.') && (line[i] != ',') && (line[i] != '!') && (line[i] != '?') && (line[i] != '-'))
                        {
                            strline += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return pathSaveFile;
        }
    }
}