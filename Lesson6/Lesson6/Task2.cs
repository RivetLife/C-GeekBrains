using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Илья Бугров
//2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
//б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
//в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
//возвращает минимум через параметр.

namespace Lesson6
{
    partial class Program
    {

        static double Func3(double a, double x) => a * Math.Pow(x, 3);

        public static void SaveFunc(string fileName, double a, double x, double b, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            while (x <= b)
            {
                bw.Write(F(a, x));
                x++;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] count = new double[fs.Length];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                count[i] = bw.ReadDouble();
                if (count[i] < min) min = count[i];
            }
            bw.Close();
            fs.Close();
            return count;
        }


            static void Task2()
        {
            Fun[] func = new Fun[3];
            func[0] = Func1;
            func[1] = Func2;
            func[2] = Func3;

            int numb = -1;
            double min = 0;

            Console.WriteLine("Выберите функцию, введя её номер:");
            Console.WriteLine("1. y = a * x^2");
            Console.WriteLine("2. y = a * sin(x)");
            Console.WriteLine("3. y = a * x^3");

            while (numb == -1)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        numb = 0;
                        break;

                    case "2":
                        numb = 1;
                        break;

                    case "3":
                        numb = 2;
                        break;

                    default:
                        Console.WriteLine("Введен неверный номер функции. Повторите ввод.");
                        break;
                }
            }

            Console.WriteLine("Введите координату начала отрезка:");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату конца отрезка:");
            double fin = Convert.ToDouble(Console.ReadLine());

            SaveFunc("data.bin", 5, start, fin, func[numb]);
            double[] count = Load("data.bin", out min);
            Console.WriteLine("Минимум функции: {0}", min);
            Console.ReadKey();

        }

    }
}
