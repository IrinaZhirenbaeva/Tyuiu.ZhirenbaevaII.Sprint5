﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint5.Task3.V8.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task3.V8
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
            Console.WriteLine(" Задание #3                                                           ");
            Console.WriteLine(" Вариант #8                                                           ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл  *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.     *");
            Console.WriteLine("* y(x) = x^2 + 1 / 3x + 4                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Массив : ");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}


       
    
