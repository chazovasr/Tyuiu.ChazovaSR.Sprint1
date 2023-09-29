using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task7.V0.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task7.V0
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
            Console.WriteLine("* Вариант #0                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая вычисляет математическое      ");
            Console.WriteLine("*выражение по исходным значениям, вводимых пользоватлем   *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("             y-z");
            Console.WriteLine("            ------");
            Console.WriteLine("            (y-x)");
            Console.WriteLine(" f = (y-x)-------------");
            Console.WriteLine("                   2");
            Console.WriteLine("            1+(y-x)");

            double x, y, z;

            Console.WriteLine("Введите значение х: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(ds.Calculate(x,y,z));
            Console.ReadKey();
        }
    }
}
