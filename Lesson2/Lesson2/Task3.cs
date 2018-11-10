using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Lesson2
{
    partial class Program
    {
        static void Task3()
        {
            int sum = 0;
            int m;
            Console.WriteLine("Введите числа. Ввод нуля будет означать конец ввода чисел.");
            do
            {
                m = Convert.ToInt32(Console.ReadLine());
                if (m % 2 != 0 && m > 0)
                {
                    sum += m;
                }
            }
            while (m != 0);
            {
                Console.WriteLine();
                Console.WriteLine("Сумма положительных нечётных чисел из числа введённых равна {0}", sum);
                Useful.Pause();
            }
        }
    }
}
