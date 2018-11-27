using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//Меню

namespace Lesson6
{
    partial class Program
    {
        static void Menu()
        {
            Console.WriteLine("Введите номер задания:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                default:
                    Console.WriteLine("Введён неверный номер задания.");
                    break;
            }
        }

        static void Main()
        {
            Menu();
        }
    }
}
