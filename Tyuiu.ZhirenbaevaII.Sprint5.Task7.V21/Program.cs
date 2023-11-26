using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZhirenbaevaII.Sprint5.Task7.V21.Lib;
using System.IO;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";

            Console.Title = "Спринт #5 | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #5                                                            ");
            Console.WriteLine(" Тема: Обработка файлов                                                  ");
            Console.WriteLine(" Задание #6                                                         ");
            Console.WriteLine(" Вариант #27                                                      ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask7V21.txt (файл взять из архива согласно вашему варианту.  *");
            Console.WriteLine("*  Создать папку в ручную С:DataSprint5 и скопировать в неё файл) в котором есть набор символьных данных   *");
            Console.WriteLine("*  Удалить все знаки препинания из файла.Полученный результат сохранить в файл OutPutDataFileTask7V21.txt.                                                                       *");
            Console.WriteLine("*  Полученный результат сохранить в файл OutPutDataFileTask7V21.txt.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Строка из файла:");

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine($"Данные находятся в файле: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Полученные данные находятся в файле:");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}









