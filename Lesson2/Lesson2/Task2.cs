using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//2.Написать метод подсчета количества цифр числа.

namespace Lesson2
{
    partial class Program
    {

        static int Numbers(string a)
        {
            return a.Length;
            
        }

        static void Task2()
        {
            Console.Write("Введите число для подсчёта цифр: ");
            string a = Console.ReadLine();
            Console.WriteLine("В этом числе {0} цифр.", Numbers(a));
            Useful.Pause();
        }
    }
}
