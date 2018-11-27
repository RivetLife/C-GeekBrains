using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Илья Бугров
//Меню

namespace Lesson5
{
    partial class Program
    {
        static void Menu()
        {
            Console.Write("Введите номер задания: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                case "3":
                    Task3();
                    break;
                default:
                    Console.WriteLine("Введён не верный номер задания.");
                    Console.ReadKey();
                    break;
            }
        }

        static void Main()
        {
            Menu();
        }
    }
}
