using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

namespace Lesson3
{
    partial class Program
    {
        static int Sum()
        {
            int numb;
            int sum = 0;
            do
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out numb))
                {
                    sum += numb;
                }
                else
                {
                    throw new ArgumentException("Введено неверное значение.");
                }
            }
            while (numb != 0);

            return sum;
        }

        static void Task3()
        {
            Console.WriteLine("Сумма введённых чисел: " + Convert.ToString(Sum()));
            Console.ReadKey();
        }

    }
}
