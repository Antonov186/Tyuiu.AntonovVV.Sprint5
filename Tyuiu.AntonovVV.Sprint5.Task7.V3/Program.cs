using Tyuiu.AntonovVV.Sprint5.Task7.V3.Lib;
namespace Tyuiu.AntonovVV.Sprint5.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Антонов В.В. | ИСПб - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #6                                                                                        *");
            Console.WriteLine("* Тема: Обработка текстовый файлов                                                                 *");
            Console.WriteLine("* Задание #7                                                                                       *");
            Console.WriteLine("* Вариант #3                                                                                       *");
            Console.WriteLine("* Выполнил: Антонов В.В. | ИСПб - 24-1                                                             *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все русские буквы из файла.             *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            string path = @"C:\Users\avv\source\repos\Tyuiu.AntonovVV.Sprint5\DataSprint5\InPutDataFileTask7V3.txt";
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V3.txt" });

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            path2 = ds.LoadDataAndSave(path);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}