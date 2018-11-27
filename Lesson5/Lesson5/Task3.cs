using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например:
//badc являются перестановкой abcd.

namespace Lesson5
{
    partial class Program
    {
        static bool IsPermutated(string a, string b)
        {
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (b != "")
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            if (a[i] == b[j])
                            {
                                b = b.Remove(j, 1);
                                break;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (b == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static void Task3()
        {
            Console.Write("Введите первую строку: ");
            string a = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string b = Console.ReadLine();
            if (IsPermutated(a, b))
            {
                Console.WriteLine("Строчки являются переставлениями друг друга.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Строчки не являются переставлениями друг друга.");
                Console.ReadKey();
            }
        }
    }
}
