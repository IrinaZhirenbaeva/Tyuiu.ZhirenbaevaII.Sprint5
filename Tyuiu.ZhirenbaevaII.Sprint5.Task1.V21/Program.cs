using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint5.Task1.V21.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #5                                                              ");
            Console.WriteLine(" Тема: Обработка файлов                                                  ");
            Console.WriteLine(" Задание #0                                                              ");
            Console.WriteLine(" Вариант #18                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до   *");
            Console.WriteLine("* трёх знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("**");
            int start = -5;
            int end = 5;
            Console.WriteLine("Начальная координата : " + start);
            Console.WriteLine("Конечная координата : " + end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(start, end);
            Console.WriteLine("Файл :" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}

        
    

