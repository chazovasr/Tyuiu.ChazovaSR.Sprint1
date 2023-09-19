﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task2.V0.Lib;

namespace Tyuiu.ChazovaSR.Sprint1.Task2.V0
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
            Console.WriteLine("* Задание #2                                              *");
            Console.WriteLine("* Вариант #0                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу, которая запрашивает исходные          ");
            Console.WriteLine("* данные и вычисляет результат по формуле x/(y-1)         *");
            Console.WriteLine("*  и печатает его на экране.                              *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            int x;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Квадрат числа Х = "+ ds.Sqr(x));

            Console.ReadLine();
        }
    }
}
