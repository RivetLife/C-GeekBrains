using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//1. б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

namespace Lesson3
{
    namespace Task2
    {
        class Complex
        {
            double im;
            double re;

            public Complex()
            {
                im = 0;
                re = 0;
            }

            public Complex(double _im, double _re)
            {          
                im = _im;
                re = _re;
            }
            public Complex Plus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = x2.im + im;
                x3.re = x2.re + re;
                return x3;
            }

            public Complex Minus(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = im - x2.im;
                x3.re = re - x2.re;
                return x3;
            }

            public Complex Multi(Complex x2)
            {
                Complex x3 = new Complex();
                x3.im = re * x2.im + im * x2.re;
                x3.re = re * x2.re - im * x2.im;
                return x3;
            }
            
            public double Im
            {
                get
                {
                    return im;
                }

                set
                {
                    if (value >= 0) im = value;
                }
            }

            public double Re
            {
                get
                {
                    return re;
                }

                set
                {
                    if (value >= 0) re = value;
                }
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

    }

    partial class Program
    {

        static void Task2()
        {
            Task2.Complex complex1 = new Task2.Complex(4, 4);
            Task2.Complex complex2 = new Task2.Complex(2, 2);
            Task2.Complex result1 = complex1.Minus(complex2);
            Task2.Complex result2 = complex1.Multi(complex2);

            Console.WriteLine("Первое комплексное число: " + complex1.ToString());
            Console.WriteLine("Второе комплексное число: " + complex2.ToString());
            Console.WriteLine("Разность чисел равна: " + result1.ToString());
            Console.WriteLine("Произведение чисел равно: " + result2.ToString());

            Console.ReadKey();
        }

    }
}
