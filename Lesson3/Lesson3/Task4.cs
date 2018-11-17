using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей.
//Написать программу, демонстрирующую все разработанные элементы класса.

namespace Lesson3
{
    class Fraction
    {
        int num;
        int denom;

        public Fraction()
        {
            num = 1;
            denom = 1;
        }

        public Fraction(int _num, int _denom)
        {
            num = _num;
            if (_denom != 0)
            {
                denom = _denom;
            }
            else
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }
        }

        public Fraction Plus(Fraction frac1)
        {
            Fraction frac2 = new Fraction();

            if (denom == frac1.denom)
            {
                frac2.num = num + frac1.num;
                frac2.denom = denom;
                return frac2;
            }
            else
            {
                Fraction frac3 = new Fraction(num, denom);
                frac3.num = frac3.num * frac1.denom;
                frac3.denom = frac3.denom * frac1.denom;

                Fraction frac4 = new Fraction(frac1.num, frac1.denom);
                frac4.num = frac1.num * denom;
                frac4.denom = frac3.denom;

                frac2.num = frac3.num + frac4.num;
                frac2.denom = frac3.denom;

                return frac2;
            }
        }

        public Fraction Minus(Fraction frac1)
        {
            Fraction frac2 = new Fraction();
            if (denom == frac1.denom)
            {
                frac2.num = num - frac1.num;
                frac2.denom = denom;
                return frac2;
            }
            else
            {
                Fraction frac3 = new Fraction(num, denom);
                frac3.num = frac3.num * frac1.denom;
                frac3.denom = frac3.denom * frac1.denom;

                Fraction frac4 = new Fraction(frac1.num, frac1.denom);
                frac4.num = frac1.num * denom;
                frac4.denom = frac3.denom;

                frac2.num = frac3.num - frac4.num;
                frac2.denom = frac3.denom;

                return frac2;
            }
        }

        public Fraction Multi(Fraction frac1)
        {
            Fraction frac2 = new Fraction();

            frac2.num = num * frac1.num;
            frac2.denom = denom * frac1.denom;

            return frac2;
        }

        public Fraction Div(Fraction frac1)
        {
            Fraction frac2 = new Fraction();

            frac2.num = num * frac1.denom;
            frac2.denom = denom * frac1.num;

            return frac2;
        }

        public string Print()
        {
            return num + "/" + denom;
        }


    }

    partial class Program
    {
        static void Task4()
        {
            Fraction fraction1 = new Fraction(7, 4);
            Fraction fraction2 = new Fraction(2, 5);

            Console.WriteLine("Первая дробь: " + fraction1.Print());
            Console.WriteLine("Вторая дробь: " + fraction2.Print());

            Fraction result1 = fraction1.Plus(fraction2);
            Fraction result2 = fraction1.Minus(fraction2);
            Fraction result3 = fraction1.Multi(fraction2);
            Fraction result4 = fraction1.Div(fraction2);

            Console.WriteLine("Результат сложения дробей: " + result1.Print());
            Console.WriteLine("Результат вычитания дробей: " + result2.Print());
            Console.WriteLine("Результат умножения дробей: " + result3.Print());
            Console.WriteLine("Результат деления дробей: " + result4.Print());

            Console.ReadKey();
        }
    }
}
