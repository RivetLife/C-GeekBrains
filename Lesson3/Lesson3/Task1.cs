using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

namespace Lesson3
{
    namespace Task1
    {
        struct Complex
        {
            public double im;
            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }
    }

    partial class Program
    {
        static void Task1()
        {
            Task1.Complex complex1;
            complex1.re = 3;
            complex1.im = 3;

            Task1.Complex complex2;
            complex2.re = 1;
            complex2.im = 1;

            Task1.Complex result = complex1.Minus(complex2);

            Console.WriteLine("Первое комплексное число: " + complex1.ToString());
            Console.WriteLine("Второе комплексное число: " + complex2.ToString());
            Console.WriteLine("Разность чисел равна: " + result.ToString());

            Console.ReadKey();
        }


    }
}
