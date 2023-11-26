﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint5.Task5.V19.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint5.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #5 | Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1";

                Console.WriteLine("**");
                Console.WriteLine(" Спринт #5                                                              ");
                Console.WriteLine(" Тема: Обработка файлов                                                  ");
                Console.WriteLine(" Задание #5                                                          ");
                Console.WriteLine(" Вариант #19                                                        ");
                Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                     ");
                Console.WriteLine("**");
                Console.WriteLine("* УСЛОВИЕ:                                                                ");
                Console.WriteLine("* Написать программу, которая берёт набор значение из                     *");
                Console.WriteLine("* InPutDataFileTask5V19.txt и находит разницу между максимальным и        *");
                Console.WriteLine("* минимальным однозначными целыми числами в файле. Результат вывести на   *");
                Console.WriteLine("* консоль.                                                                *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("*                                                                        *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
                Console.WriteLine("Массив : ");

                string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
                Console.WriteLine("Данные находятся в файле: " + path);


                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                double res = ds.LoadFromDataFile(path);
                Console.WriteLine("Разность максимального и минимального однозначных целых чисел в файле = " + res);
                Console.ReadKey();
            }
        }
    }
}





