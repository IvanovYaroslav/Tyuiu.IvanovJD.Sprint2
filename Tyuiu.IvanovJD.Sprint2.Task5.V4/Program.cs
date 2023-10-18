using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint2.Task5.V4.Lib;

namespace Tyuiu.IvanovJD.Sprint2.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #1 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: оператор switch                                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич | ПКТБ-23-2                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();
            Console.Write("Введите номер масти: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Масть: " + ds.FindCardSuit(value));

            Console.ReadKey();
        }


    }
}