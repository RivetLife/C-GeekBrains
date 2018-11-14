using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

namespace Lesson2
{
    partial class Program
    {
        static void Menu()
        {
            Console.WriteLine("Выберите задание, используя ввод цифры, соответствующей номеру задания.");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                case "7":
                    Task7();
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Программа завершает работу.");
                    Useful.Pause();
                    break;
            }

        }

        static void Main()
        {
            Menu();
        }
    }
}
