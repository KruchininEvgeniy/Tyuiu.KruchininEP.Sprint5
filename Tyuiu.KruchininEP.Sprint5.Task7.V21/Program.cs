using Tyuiu.KruchininEP.Sprint5.Task7.V21.Lib;
namespace Tyuiu.KruchininEP.Sprint5.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Кручинин Е. П. | РППб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Кручинин Е. П. | РППб25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все знаки препинания из файла. Результат сохранить в файл.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string pathin = @"C:\Users\HASEE\Desktop\ТИУ\DataSprint5\InPutDataFileTask7V21.txt";
            Console.WriteLine("Данные находятся в файле: " + pathin);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            string pathout = ds.LoadDataAndSave(pathin);

            Console.WriteLine(pathout);

            Console.ReadKey();
        }
    }
}