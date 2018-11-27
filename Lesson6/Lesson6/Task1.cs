using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//1. Изменить программу вывода функции так, чтобы можно было передавать функции типа 
//double (double,double).
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

public delegate double Fun(double a, double x);

namespace Lesson6
{
    partial class Program
    {

        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("------ A -------- X -------- Y --");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x++;
            }
            Console.WriteLine("---------------------------------");
        }

        public static double Func1(double a, double x) => a * Math.Pow(x, 2);

        public static double Func2(double a, double x) => a * Math.Sin(x);

        static void Task1()
        {
            Console.WriteLine();
            Console.WriteLine("Таблица функции a*x^2:");
            Console.WriteLine();
            Table(Func1, 2, -2, 2);
            Console.WriteLine();
            Console.WriteLine("Таблица функции a*sin(x):");
            Console.WriteLine();
            Table(Func2, 2, -2, 2);
            Console.ReadKey();
        }

    }
}
