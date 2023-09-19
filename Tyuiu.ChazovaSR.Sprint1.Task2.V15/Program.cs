using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task1.V15.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях *");
            Console.WriteLine("* Задание #1                                              *");
            Console.WriteLine("* Вариант #15                                             *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая запрашивает исходные          ");
            Console.WriteLine("* данные и вычисляет результат по формуле (4 + 2 * x) / 7 *");
            Console.WriteLine("*  и печатает его на экране.                              *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            double x;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    
    }
}
