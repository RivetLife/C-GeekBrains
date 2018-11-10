using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//7. Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);

namespace Lesson2
{
    partial class Program
    {

        static void Rekurs1(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                Rekurs1(++a, b);
            }
        }


        static void Task7()
        {
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Rekurs1(a, b);
            Useful.Pause();
        }
    }
}
