using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint2.Task6.V8.Lib;

namespace Tyuiu.IvanovJD.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #8                                                                *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич | ПКТБ-23-2                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
           
            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string res = Convert.ToString(ds.FindDateOfPreviousDay(m, n));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
