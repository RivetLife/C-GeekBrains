using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//1.Написать метод, возвращающий минимальное из трёх чисел.

namespace Lesson2
{
    partial class Program
    {
        static void Task1()
        {
            int a, b, c;
            Console.WriteLine("Введите числа:");
            Console.Write("А:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("В:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("С:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Минимальное из этих чисел - " + Useful.Min(a, b, c));
            Useful.Pause();
        }
    }
}
