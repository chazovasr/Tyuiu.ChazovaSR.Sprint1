using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChazovaSR.Sprint1.Task0.V0.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
            Console.WriteLine("* Задание #0                                        *");
            Console.WriteLine("* Вариант #0                                        *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1    *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                           ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*Написать программу на С#, вычисляет выражение       ");
            Console.WriteLine("* 10 / (2 + 3) и печатает результат на экране.      *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* 10 / (2 + 3)                                       ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                         ");
            Console.WriteLine("*****************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
