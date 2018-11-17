using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Илья Бугров
//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) * Добавьте статический метод для считывания массива из текстового файла.
//Метод должен возвращать массив целых чисел;


namespace Lesson4
{
    static class Massives
    {
        public static void Couples(int[] mass)
        {
            int couples = 0;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if ((mass[i] % 3 == 0) ^ (mass[i + 1] % 3 == 0))
                {
                    couples++;
                }
            }
            Console.WriteLine("Количество пар: " + couples);
        }

        public static int[] MassRead(string fileName)
        {
            int n = 0;
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                n++;
                sr.ReadLine();
            }
            sr.Close();

            int[] mass = new int[n];

            sr = new StreamReader(fileName);
            int i = 0;
            while (!sr.EndOfStream)
            {
                mass[i] = int.Parse(sr.ReadLine());
                i++;
            }
            sr.Close();
            return mass;
        }

        public static void MassPrint(int[] mass)
        {
            Console.WriteLine("Исходный массив: ");
            foreach (int el in mass)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();
        }
    }

    partial class Program
    {
        static void Task2()
        {
        int[] mass = Massives.MassRead("C:\\Data\\text.txt");
        Massives.MassPrint(mass);
        Massives.Couples(mass);
        Console.ReadKey();
        }
    }
}
