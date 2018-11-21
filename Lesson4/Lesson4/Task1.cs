using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//1. Дан  целочисленный  массив  из 20 элементов.
//Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами. 
//Написать программу, позволяющую найти и вывести количество пар элементов массива, 
//в которых только одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива.
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

namespace Lesson4
{
    partial class Program
    {
        static int[] MassRand(int[] mass, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(min, max);
            }
            return mass;
        }

        static int Couples(int[] mass)
        {
            int couples = 0;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if ((mass[i] % 3 == 0) ^ (mass[i+1] % 3 == 0))
                {
                    couples++;
                }
            }
            return couples;
        }

        static void MassPrint(int[] mass)
        {
            Console.WriteLine("Исходный массив: ");
            foreach(int el in mass)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();
        }

        static void Task1()
        {
            int[] mass = new int[20];
            mass = MassRand(mass, -10000, 10000);
            MassPrint(mass);
            Console.WriteLine("Количество пар: " + Couples(mass));
            Console.ReadKey();
        }
    }
}
