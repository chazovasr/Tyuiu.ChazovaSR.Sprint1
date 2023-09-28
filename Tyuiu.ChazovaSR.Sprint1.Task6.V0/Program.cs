using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChazovaSR.Sprint1.Task6.V0.Lib;
namespace Tyuiu.ChazovaSR.Sprint1.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                   *");
            Console.WriteLine("* Задание #6                                              *");
            Console.WriteLine("* Вариант #0                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*Написать программу: пользователь вводит строку.           ");
            Console.WriteLine("*Удалить из строки все символы пробела и символ *         *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите строку ");
            string str = Console.ReadLine();

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(ds.WorkWithText(str));

            Console.ReadLine();
        }
    }
}
