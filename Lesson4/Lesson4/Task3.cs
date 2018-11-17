using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//а) Дописать класс для работы с одномерным массивом.
//Реализовать конструктор, создающий массив определенного размера и
//заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
//возвращающий новый массив с измененными знаками у всех элементов массива
//(старый массив, остается без изменений),  метод Multi,
//умножающий каждый элемент массива на определённое число, свойство MaxCount,
//возвращающее количество максимальных элементов. 

namespace Lesson4
{
    class Massive
    {
        int[] mass;

        public Massive(int size, int start, int step)
        {
            mass = new int[size];
            mass[0] = start;
            for (int i = 1; i < mass.Length; i++)
            {
                mass[i] = mass[i - 1] + step;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int el in mass)
                {
                    sum += el;
                }
                return sum;
            }
        }

        public int[] Inverse()
        {
            int[] inv = new int[mass.Length - 1];
            for (int i = 0; i < mass.Length; i++)
            {
                inv[i] = mass[i] * -1;
            }
            return inv;
        }

        public void Multi(int multiplier)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] *= multiplier;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = mass[0];
                int maxCount = 0;
                foreach(int el in mass)
                {
                    if (el > max)
                    {
                        max = el;
                    }
                }
                foreach(int el in mass)
                {
                    if (el == max)
                    {
                        maxCount++;
                    }
                }
                return maxCount;
            }
        }
    }

    partial class Program
    {
        static void Task3()
        {
            Massive mass = new Massive(20, 0, 5);
            Console.WriteLine("Сумма всех элементов массива: " + mass.Sum);
            int[] inversed = mass.Inverse();
            mass.Multi(2);
            Console.WriteLine("Количество максимальных элементов массива: " + mass.MaxCount);
            Console.ReadKey();
        }
    }
}
