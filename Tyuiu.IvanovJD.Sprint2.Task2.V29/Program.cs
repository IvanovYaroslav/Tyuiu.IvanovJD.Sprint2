using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint2.Task2.V29.Lib;

namespace Tyuiu.IvanovJD.Sprint2.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #29                                                               *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич | ПКТБ-23-2                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();

            Console.Write("Введите х: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res) Console.WriteLine("Точка находится в заштрихованной области");
            else Console.WriteLine("Точка не находится в заштрихованной области");

            Console.ReadKey();

        }
    }
}