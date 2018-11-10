using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulThings;

//Илья Бугров

//5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и
//сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Lesson2
{
    partial class Program
    {
        static void Task5()
        {
            Console.Write("Введите свой рост (в метрах): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой вес (в килограммах): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double imt = Useful.IMT(height, weight);
            if (imt < 18)
            {
                Console.WriteLine("Похоже, вам надо набрать вес.");
                Console.WriteLine("Нужный для набора вес - " + ((18 * (height * height)) - weight) + " кг.");
                Useful.Pause();
            }
            else if (imt > 25)
            {
                Console.WriteLine("Похоже, вам надо похудеть.");
                Console.WriteLine("Избыточный вес - " + (weight - (25 * (height * height))) + " кг.");
                Useful.Pause();
            }
            else
            {
                Console.WriteLine("Ваш вес в норме.");
                Useful.Pause();
            }
        }
    }
}
