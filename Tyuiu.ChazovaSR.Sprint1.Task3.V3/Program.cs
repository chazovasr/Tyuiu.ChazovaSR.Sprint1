using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task3.V3.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                 *");
            Console.WriteLine("* Задание #3                                              *");
            Console.WriteLine("* Вариант #3                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая запрашивает исходные          ");
            Console.WriteLine("*данные, вычисляет объем параллелепипеда и                *");
            Console.WriteLine("*и печатает результат на экране.                          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            double length = 9;
            double width = 7.5;
            double height = 5;
            Console.WriteLine("Длина параллелепипеда = " + length);
            Console.WriteLine("Ширина параллелепипеда =" + width);
            Console.WriteLine("Высота параллелепипеда =" + height);

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Площадь прямоугольника= " + ds.ParallelepipedVolume(length, width, height));

            Console.ReadLine();
        }
    }
}
