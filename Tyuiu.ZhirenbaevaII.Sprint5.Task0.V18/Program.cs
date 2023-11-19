using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint5.Task0.V18.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task0.V18
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
            Console.WriteLine("*            x                                                            *");
            Console.WriteLine("* y = ---------------                                                     *");
            Console.WriteLine("*          ________                                                       *");
            Console.WriteLine("*      __ /  2                                                            *");
            Console.WriteLine("*       |/  x  + x                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");
            int x = 3;
            Console.WriteLine("X = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string result = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + result);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
