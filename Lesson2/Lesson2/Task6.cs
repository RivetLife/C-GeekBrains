using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
//Хорошим называется число, которое делится на сумму своих цифр.
//Реализовать подсчет времени выполнения программы, используя структуру DateTime.

namespace Lesson2
{
    partial class Program
    {


        static void Task6()
        {
            DateTime start = DateTime.Now;
            int good = 0;
            for(int i = 1; i < 1000000000; i++)
            {
                if (i % Useful.NumbSumm(i) == 0)
                {
                    good++;
                }
            }
            Console.WriteLine("Хороших чисел - {0}, программа завершила работу за {1}.", good, (DateTime.Now - start));
            Useful.Pause();
        }
    }
}
