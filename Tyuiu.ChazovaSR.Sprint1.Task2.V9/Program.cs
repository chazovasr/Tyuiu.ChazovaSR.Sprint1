using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task2.V9.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Арифметические оператора в С#                     *");
            Console.WriteLine("* Задание #3                                              *");
            Console.WriteLine("* Вариант #9                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя    ");
            Console.WriteLine("*исходные данные, выполняет указанные расчёты и           *");
            Console.WriteLine("*печатает результат на экране. Известен радиус шара.      *");
            Console.WriteLine("*Вычислить примерный объём шара.                          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            int r;
            Console.WriteLine("Введите значение r:");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Объем шара примерно = " + ds.CalculateVolumeCircle(r));

            Console.ReadLine();
        }
    }
}
