using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint1.Task7.V5.Lib;

namespace Tyuiu.AbdullinAI.Sprint1.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до   *");
            Console.WriteLine("* 3 знаков после запятой.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                  ln|cos x|");
            Console.WriteLine("  f =             --------- ");
            Console.WriteLine("                 ln(1 + x^2)");


            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (Math.Abs(Math.Cos(x)) == 1)
            {
                Console.WriteLine("Данное значение x недопустимо, так как аргумент логарфима не должен быть равен единице!!!!");

            }
            else if(Math.Abs(Math.Cos(x)) == 0)
            {
                Console.WriteLine("Данное значение x недопустимо, так как аргумент логарфима не может быть равен нулю!!!!");
            }
            else if(x == 0)
            {
                Console.WriteLine("Данное значение x недопустимо, так как аргумент логарфима не должен быть равен единице!!!!");
            }
            else
            {
                Console.WriteLine("Результат: " + ds.Calculate(x));
            }
            Console.ReadKey();

            




        }
    }
}
