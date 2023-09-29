using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task7.V16.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
            Console.WriteLine("* Задание #7                                              *");
            Console.WriteLine("* Вариант #16                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая вычисляет математическое      ");
            Console.WriteLine("*выражение по исходным значениям, вводимых пользоватлем   *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("                           2   ");
            Console.WriteLine("                2    (cos(x))              2 ");
            Console.WriteLine(" f = sin(sqrt(x)) + ---------  - sin(sqrt(x - 1))          ");
            Console.WriteLine("                         3 ");
            Console.WriteLine("                      3*x  ");

            double x;

            Console.WriteLine("Введите значение х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
